using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using File_Explorer_v2.Properties;

namespace File_Explorer_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reload();
            ButtonDisks(DiskRightPanel);
            ButtonDisks(DiskLeftPanel);
        }

        // Построение списка файлов/папок        
        private void Fill_listviewFolders(string path, ListView list)
        {
            list.Clear();
            var lv = Build.BuildColumnHeaders(list);
            var directory = new DirectoryInfo(path);

            if (path != directory.Root.ToString())
                lv.Items.Add(new ListViewItem(new[] {"...", "", "", ""}));

            var cntDir = 0;

            foreach (var dirName in directory.GetDirectories())
            {
                //фильтр на скрытые папки
                if (!Settings.Default.ShowHidden)
                    if ((dirName.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                var lvDiri = new ListViewItem(new[]
                {
                    dirName.Name,
                    "-",
                    "<Папка>",
                    dirName.LastAccessTime.ToShortDateString() + " " +
                    dirName.LastAccessTime.ToShortTimeString(),
                    dirName.FullName
                });

                if (cntDir == 0)
                {
                    lvDiri.Selected = true;
                    lvDiri.Focused = true;
                }

                lv.Items.Add(lvDiri);
                cntDir++;
            }
        }

        private void Fill_listviewFiles(string path, ListView list)
        {
            var directory = new DirectoryInfo(path);

            foreach (var dirFile in directory.GetFiles())
            {
                //фильтр на скрытые файлы
                if (!Settings.Default.ShowHidden)
                    if ((dirFile.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                var ListFile = new ListViewItem(new[]
                {
                    Path.GetFileNameWithoutExtension( /*path +*/ dirFile.Name + dirFile.Extension),
                    dirFile.Extension,
                    dirFile.Length.ToString(),
                    dirFile.LastAccessTime.ToShortDateString() + " " +
                    dirFile.LastAccessTime.ToShortTimeString(),
                    dirFile.FullName
                });
                list.Items.Add(ListFile);
            }
        }

        private void Reload()
        {
            Fill_listviewFolders(Settings.Default.LeftPath, listView_left);
            Fill_listviewFiles(Settings.Default.LeftPath, listView_left);
            Fill_listviewFolders(Settings.Default.RightPath, listView_right);
            Fill_listviewFiles(Settings.Default.RightPath, listView_right);
        }

        private void DriveChange(object sender, EventArgs e)
        {
            var nP = ((Button) sender).Tag.ToString();
            try
            {
                if (nP == "DiskLeftPanel")
                    Settings.Default.LeftPath = ((Button) sender).Name;

                if (nP == "DiskRightPanel")
                    Settings.Default.RightPath = ((Button) sender).Name;

                Reload();
            }
            catch
            {
                MessageBox.Show("Вставьте диск!",
                    "Внимание!");
            }
        }

        private void ButtonDisks(Panel pnl)
        {
            var sDi = DriveInfo.GetDrives();

            var sPoint = 0;
            foreach (var ld in sDi)
            {
                var ldButton = new Button();
                ldButton.Location = new Point(sPoint, 2);
                ldButton.Name = ld.Name;
                ldButton.Size = new Size(30, 20);
                ldButton.TabIndex = 3;
                ldButton.Text = ld.Name;
                ldButton.UseVisualStyleBackColor = true;
                ldButton.Font = new Font(ldButton.Font.FontFamily, 7);
                ldButton.Click += DriveChange;
                ldButton.Tag = pnl.Name;
                pnl.Controls.Add(ldButton);
                sPoint = sPoint + 37;
            }
        }

        private void ToolStripMenuItem_paste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запоминаем путь откуда копировать");
        }

        private void toolStripMenuItem_copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Копируем по выбранному в списке пути файл");
        }

        private void listView_left_ItemActivate(object sender, EventArgs e)
        {
            label1.Text = Settings.Default.LeftPath;
            var LeftNOTChangedPath = Settings.Default.LeftPath;
            var Changed = listView_left.FocusedItem.Text;
            var LeftChangedPath = Build.PrepareLocalPath(Settings.Default.LeftPath, Changed);

            try
            {
                if (Path.GetExtension(LeftChangedPath) == "")
                {
                    Fill_listviewFolders(LeftChangedPath, listView_left);
                    Fill_listviewFiles(LeftChangedPath, listView_left);
                    Settings.Default.LeftPath = LeftChangedPath;
                }
                else
                {
                    Process.Start(LeftChangedPath);
                    Settings.Default.LeftPath = LeftNOTChangedPath;
                }

                label1.Text = Settings.Default.LeftPath;
            }
            catch
            {
                MessageBox.Show("Данный файл не может быть открыт");
            }
        }

        private void listView_right_ItemActivate(object sender, EventArgs e)
        {
            var RigthNOTChangedPath = Settings.Default.RightPath;
            var Changed = listView_right.FocusedItem.Text;
            var RigthChangedPath = Build.PrepareLocalPath(Settings.Default.RightPath, Changed);
            Settings.Default.RightPath = RigthChangedPath;
            try
            {
                if (Path.GetExtension(RigthChangedPath) == "")
                {
                    Fill_listviewFolders(RigthChangedPath, listView_right);
                    Fill_listviewFiles(RigthChangedPath, listView_right);
                    Settings.Default.RightPath = RigthChangedPath;
                }
                else
                {
                    Process.Start(RigthChangedPath);
                    Settings.Default.RightPath = RigthNOTChangedPath;
                }
            }
            catch
            {
                MessageBox.Show("Данный файл не может быть открыт");
            }

            label2.Text = Settings.Default.RightPath;
        }
    }

    internal class Build
    {
        // подготовка локального пути
        public static string PrepareLocalPath(string path, string Changed)
        {
            string ChangedPath;
            var directory = new DirectoryInfo(path);
            if (Changed == "...")
            {
                ChangedPath = directory.Parent.FullName;
            }
            else
            {
                var addSlashes = "";

                if (directory.Root.ToString() != directory.FullName) addSlashes = "\\";

                ChangedPath = directory.FullName + addSlashes + Changed;
            }

            return ChangedPath;
        }

        // Построение колонок
        public static ListView BuildColumnHeaders(ListView lv)
        {
            var columns = new ColumnHeader[5];

            columns[0] = new ColumnHeader();
            columns[0].Text = "Файл";
            columns[0].Width = 200;

            columns[1] = new ColumnHeader();
            columns[1].Text = "Тип";
            columns[1].Width = 40;

            columns[2] = new ColumnHeader();
            columns[2].Text = "Размер";
            columns[2].Width = 60;

            columns[3] = new ColumnHeader();
            columns[3].Text = "Дата";
            columns[3].Width = 100;

            columns[4] = new ColumnHeader();
            columns[4].Text = "Путь";
            columns[4].Width = 200;

            lv.Columns.AddRange(columns);

            return lv;
        }
    }
}