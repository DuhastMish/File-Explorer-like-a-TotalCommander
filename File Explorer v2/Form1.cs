using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using File_Explorer_v2.Properties;

namespace File_Explorer_v2
{
    public partial class TotalCommander : Form
    {
        IniFile iniFile;

        public TotalCommander()
        {
            InitializeComponent();
            iniFile = IniFile.LoadIniFile();
        }

        public string FileName; //Имя файла
        public string ToDir; //Путь вставки файла
        public string FromDir; //Путь копирования файла
        public string BeforeChangedDiskRight; //Старый путь перед нажатием на кнопку диска
        public string BeforeChangedDiskLeft; //Старый путь перед нажатием на кнопку диска
        public bool ActiveListViewLeft = true; //Какой листвью активный
        public bool ActiveListViewRight;

        private void Form1_Load(object sender, EventArgs e) //Загрузка данных при первом запуске
        {
            Settings.Default.LeftPath = iniFile.LeftPathIni;
            if (!Directory.Exists(Settings.Default.LeftPath))
                Settings.Default.LeftPath = "C:\\";
            Settings.Default.RightPath = iniFile.RightPathIni;
            if (!Directory.Exists(Settings.Default.RightPath))
                Settings.Default.RightPath = "C:\\";
            ReloadLeft();
            ReloadRight();
            ButtonDisks(DiskRightPanel);
            ButtonDisks(DiskLeftPanel);
            textBox1.Text = Settings.Default.LeftPath;
            textBox2.Text = Settings.Default.RightPath;
            splitContainer1.SplitterDistance = Settings.Default.SplitDistatnce;
            Location = Settings.Default.WinLocation;
            Size = Settings.Default.WinSize;
        }

        private static void Fill_listviewFolders(string path, ListView list) //Заполнение папок
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

        private static void
            Fill_listviewFiles(string path, ListView list) //Заполнение файлов. Можно обьеденить с папками
        {
            var directory = new DirectoryInfo(path);

            foreach (var dirFile in directory.GetFiles())
            {
                //фильтр на скрытые файлы
                if (!Settings.Default.ShowHidden)
                    if ((dirFile.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                var listFile = new ListViewItem(new[]
                {
                    Path.GetFileNameWithoutExtension( /*path +*/ dirFile.Name + dirFile.Extension),
                    dirFile.Extension,
                    dirFile.Length.ToString(),
                    dirFile.LastAccessTime.ToShortDateString() + " " +
                    dirFile.LastAccessTime.ToShortTimeString(),
                    dirFile.FullName
                });
                list.Items.Add(listFile);
            }
        }

        private void ReloadLeft() //Новое заполнение левого
        {
            Fill_listviewFolders(Settings.Default.LeftPath, listView_left);
            Fill_listviewFiles(Settings.Default.LeftPath, listView_left);
        }

        private void ReloadRight() //Новое заполнение правого
        {
            Fill_listviewFolders(Settings.Default.RightPath, listView_right);
            Fill_listviewFiles(Settings.Default.RightPath, listView_right);
        }

        private void DriveChange(object sender, EventArgs e) //Выполнение нажатий на кнопоки дисков
        {
            var nP = ((Button) sender).Tag.ToString();
            try
            {
                if (nP == "DiskLeftPanel")
                {
                    BeforeChangedDiskLeft = Settings.Default.LeftPath;
                    Settings.Default.LeftPath = ((Button) sender).Name;
                    textBox1.Text = Settings.Default.LeftPath;
                    ReloadLeft();
                }
            }
            catch
            {
                MessageBox.Show("Вставьте диск!",
                    "Внимание!");
                Settings.Default.LeftPath = BeforeChangedDiskLeft;
                textBox1.Text = BeforeChangedDiskLeft;
                ReloadLeft();
            }

            try
            {
                if (nP == "DiskRightPanel")
                {
                    BeforeChangedDiskRight = Settings.Default.RightPath;
                    Settings.Default.RightPath = ((Button) sender).Name;
                    textBox2.Text = Settings.Default.RightPath;
                    ReloadRight();
                }
            }
            catch
            {
                MessageBox.Show("Вставьте диск!",
                    "Внимание!");
                Settings.Default.RightPath = BeforeChangedDiskRight;
                textBox2.Text = BeforeChangedDiskRight;
                ReloadRight();
            }
        }

        private void ButtonDisks(Panel pnl) //Генерация кнопок согласно дискам
        {
            var sDi = DriveInfo.GetDrives();

            var sPoint = 0;
            foreach (var ld in sDi)
            {
                var ldButton = new Button
                {
                    Location = new Point(sPoint, 2),
                    Name = ld.Name,
                    Size = new Size(30, 20),
                    TabIndex = 3,
                    Text = ld.Name,
                    UseVisualStyleBackColor = true
                };
                ldButton.Font = new Font(ldButton.Font.FontFamily, 7);
                ldButton.Click += DriveChange;
                ldButton.Tag = pnl.Name;
                pnl.Controls.Add(ldButton);
                sPoint = sPoint + 37;
            }
        }

        void CopyDir(string FromDir, string ToDir) //Копирование всех подкатологов и файлов выбранной папки
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }

            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private void listView_left_ItemActivate(object sender, EventArgs e) //Переход/Открытие папок и файлов
        {
            var leftNotChangedPath = Settings.Default.LeftPath;
            var changed = listView_left.FocusedItem.Text;
            var leftChangedPath = Build.PrepareLocalPath(Settings.Default.LeftPath, changed);

            try
            {
                if (Directory.Exists(leftChangedPath))
                {
                    Fill_listviewFolders(leftChangedPath, listView_left);
                    Fill_listviewFiles(leftChangedPath, listView_left);
                    Settings.Default.LeftPath = leftChangedPath;
                }
                else
                {
                    Process.Start(leftChangedPath);
                    Settings.Default.LeftPath = leftNotChangedPath;
                }
            }
            catch
            {
                MessageBox.Show("Данный файл не может быть открыт");
            }

            textBox1.Text = Settings.Default.LeftPath;
        }

        private void listView_right_ItemActivate(object sender, EventArgs e) //Переход/Открытие папок и файлов
        {
            var rigthNotChangedPath = Settings.Default.RightPath;
            var changed = listView_right.FocusedItem.Text;
            var rigthChangedPath = Build.PrepareLocalPath(Settings.Default.RightPath, changed);
            Settings.Default.RightPath = rigthChangedPath;
            try
            {
                if (Directory.Exists(rigthChangedPath))
                {
                    Fill_listviewFolders(rigthChangedPath, listView_right);
                    Fill_listviewFiles(rigthChangedPath, listView_right);
                    Settings.Default.RightPath = rigthChangedPath;
                }
                else
                {
                    Process.Start(rigthChangedPath);
                    Settings.Default.RightPath = rigthNotChangedPath;
                }
            }
            catch
            {
                MessageBox.Show("Данный файл не может быть открыт");
            }

            textBox2.Text = Settings.Default.RightPath;
        }

        private void button_move_Click(object sender, EventArgs e) //Копка переместить
        {
            try
            {
                if (ActiveListViewLeft)
                {
                    ToDir = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName);
                    if (Directory.Exists(FromDir))
                    {
                        Directory.Move(FromDir, ToDir);
                    }
                    else
                    {
                        File.Move(FromDir, ToDir);
                    }

                    ReloadLeft();
                    ReloadRight();
                }
                else
                {
                    if (!ActiveListViewRight) return;
                    ToDir = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
                    if (Directory.Exists(FromDir))
                    {
                        Directory.Move(FromDir, ToDir);
                    }
                    else
                    {
                        File.Move(FromDir, ToDir);
                    }

                    ReloadRight();
                    ReloadLeft();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e) //Кнопка удалить
        {
            if (ActiveListViewLeft)
            {
                FileName = listView_left.FocusedItem.Text;
                FromDir = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName);
                if (Directory.Exists(FromDir))
                {
                    Directory.Delete(FromDir, true);
                }
                else
                {
                    File.Delete(FromDir);
                }

                ReloadLeft();
            }
            else
            {
                if (!ActiveListViewRight) return;
                FileName = listView_right.FocusedItem.Text;
                FromDir = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
                if (Directory.Exists(FromDir))
                {
                    Directory.Delete(FromDir, true);
                }
                else
                {
                    File.Delete(FromDir);
                }

                ReloadRight();
            }
        }

        private void button_paste_Click(object sender, EventArgs e) //Кнопка вставить
        {
            if (ActiveListViewLeft)
            {
                ToDir = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName);
                try
                {
                    if (Directory.Exists(FromDir))
                    {
                        CopyDir(FromDir, ToDir);
                    }
                    else
                    {
                        File.Copy(FromDir, ToDir, true);
                    }

                    ReloadLeft();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //Обработчик в основном на админские права
                }
            }
            else
            {
                if (!ActiveListViewRight) return;
                ToDir = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
                try
                {
                    if (Directory.Exists(FromDir))
                    {
                        CopyDir(FromDir, ToDir);
                    }
                    else
                    {
                        File.Copy(FromDir, ToDir, true);
                    }

                    ReloadRight();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //Обработчик в основном на админские права
                }

                Fill_listviewFolders(Settings.Default.RightPath, listView_right);
                Fill_listviewFiles(Settings.Default.RightPath, listView_right);
            }
        }

        private void button_copy_Click(object sender, EventArgs e) //Кнопка копировать
        {
            if (ActiveListViewLeft)
            {
                FileName = listView_left.FocusedItem.Text;
                FromDir = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName);
            }
            else
            {
                if (!ActiveListViewRight) return;
                FileName = listView_right.FocusedItem.Text;
                FromDir = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
            }
        }

        private void listView_left_MouseDown(object sender, MouseEventArgs e) //Обработчик нажатия для активации листвью
        {
            ActiveListViewLeft = true;
            ActiveListViewRight = false;
        }

        private void
            listView_right_MouseDown(object sender, MouseEventArgs e) //Обработчик нажатия для активации листвью
        {
            ActiveListViewRight = true;
            ActiveListViewLeft = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Прописывание пути
        {
            try //Чтобы не выбивало при изменении пути
            {
                Settings.Default.LeftPath = textBox1.Text;
                ReloadLeft();
            }
            catch
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Прописывание пути
        {
            try //Чтобы не выбивало при изменении пути
            {
                Settings.Default.RightPath = textBox2.Text;
                ReloadRight();
            }
            catch
            {
            }
        }

        private void button_create_Click(object sender, EventArgs e) //Создание папки через новую форму
        {
            var newFolder = new CreateFolder();
            newFolder.Load += delegate
            {
                newFolder.Location = new Point(Settings.Default.WinLocation.X + (Settings.Default.WinSize.Width/2) ,Settings.Default.WinLocation.Y + Settings.Default.WinSize.Height/2);
                
            };
            
            newFolder.Show();
            newFolder.FormClosing += (senderr, eventArgs) => //Выполнение действия после закрытия формы
            {
                if (ActiveListViewLeft)
                {
                    Directory.CreateDirectory(
                        Build.PrepareLocalPath(Settings.Default.LeftPath, CreateFolder.NameFolder));
                    ReloadLeft();
                }
                else
                {
                    if (!ActiveListViewRight) return;
                    Directory.CreateDirectory(Build.PrepareLocalPath(Settings.Default.RightPath,
                        CreateFolder.NameFolder));
                    ReloadRight();
                }
            };
        }

        private void TotalCommander_KeyDown(object sender, KeyEventArgs e) //Обработчик нажатия кнопок клавиатуры
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                {
                    button_copy_Click(sender, e);
                    break;
                }
                case Keys.F6:
                {
                    button_paste_Click(sender, e);
                    break;
                }
                case Keys.F7:
                {
                    button_move_Click(sender, e);
                    break;
                }
                case Keys.F8:
                {
                    button_delete_Click(sender, e);
                    break;
                }
                case Keys.F9:
                {
                    button_create_Click(sender, e);
                    break;
                }
            }
        }

        private void TotalCommander_FormClosing(object sender, FormClosingEventArgs e) //Закрытие формы, сохранение всех параметров
        {
            iniFile.LeftPathIni = Settings.Default.LeftPath;
            iniFile.RightPathIni = Settings.Default.RightPath;
            //iniFile.SplitDistance = splitContainer1.SplitterDistance;
            iniFile.SaveIniFile();
            Settings.Default.SplitDistatnce += splitContainer1.SplitterDistance;
            Settings.Default.WinLocation = Location;
            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.WinSize = Size;
            }
            else
            {
                Settings.Default.WinSize = RestoreBounds.Size;
            }

            Settings.Default.Save();
        }

        private void listView_left_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>) e.Data.GetData(typeof(List<ListViewItem>)); //Список элементов и их пути
                foreach (ListViewItem lvi in items) //Для каждого элемента
                {
                    var FileName = lvi.Text; //Имя
                    var PathTo = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName); //Директории
                    var PathFrom = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
                    if (Path.GetExtension(PathTo) == "") //Проверка на расширение (пака\файл)
                    {
                        try //Копирование папки
                        {
                            CopyDir(PathFrom, PathTo);
                            Directory.Delete(PathFrom, true);
                        }
                        catch
                        {
                        }
                    }
                    else //Копирование файла
                    {
                        try
                        {
                            File.Copy(PathFrom, PathTo, true);
                            File.Delete(PathFrom);
                        }
                        catch
                        {
                        }
                    }

                    ReloadLeft();
                    ReloadRight();
                }
            }
        }

        private void listView_left_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>(); //Массив для всех выбранных элементов
            items.Add((ListViewItem) e.Item); //Копируем первый
            foreach (ListViewItem lvi in listView_left.SelectedItems) //Копируем остальные
            {
                {
                    items.Add(lvi);
                }
            }

            listView_left.DoDragDrop(items, DragDropEffects.Move);
        }

        private void listView_right_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>(); //Массив для всех выбранных элементов
            items.Add((ListViewItem) e.Item); //Копируем первый
            foreach (ListViewItem lvi in listView_right.SelectedItems) //Копируем остальные
            {
                {
                    items.Add(lvi);
                }
            }

            listView_right.DoDragDrop(items, DragDropEffects.Move);
        }

        private void listView_right_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>) e.Data.GetData(typeof(List<ListViewItem>));
                foreach (var lvi in items)
                {
                    var FileName = lvi.Text;
                    var PathTo = Build.PrepareLocalPath(Settings.Default.RightPath, FileName);
                    var PathFrom = Build.PrepareLocalPath(Settings.Default.LeftPath, FileName);
                    if (Path.GetExtension(PathTo) == ""
                    ) //если файл не имеет расширение то это папка(не имеет занчения какую строку брать , так)
                    {
                        try
                        {
                            CopyDir(PathFrom, PathTo);
                            Directory.Delete(PathFrom, true);
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            File.Copy(PathFrom, PathTo, true);

                            File.Delete(PathFrom);
                        }
                        catch
                        {
                        }
                    }

                    ReloadLeft();
                    ReloadRight();
                }
            }
        }

        private void listView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void TotalCommander_Resize(object sender, EventArgs e)
        {
            //splitContainer1.Width = ClientRectangle.Width;
            int x = (ClientRectangle.Width - 7 * 5) / 6;
            button_copy.Width = x;
            button_copy.Left = 10;
            button_create.Width = x;
            button_create.Left =4*(x + 10) + 10;
            button_delete.Width = x;
            button_delete.Left = 3 * (x + 10) + 10;
            button_move.Width = x;
            button_move.Left = 2 * (x + 10) + 10;
            button_paste.Width = x;
            button_paste.Left = (x + 10) + 10;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //Settings.Default.SplitDistatnce = splitContainer1.SplitterDistance;
        }
    }

    internal class Build
    {
        // подготовка локального пути
        public static string PrepareLocalPath(string path, string changed)
        {
            string changedPath;
            var directory = new DirectoryInfo(path);
            if (changed == "...")
            {
                changedPath = directory.Parent.FullName;
            }
            else
            {
                var addSlashes = "";

                if (directory.Root.ToString() != directory.FullName) addSlashes = "\\";

                changedPath = directory.FullName + addSlashes + changed;
            }

            return changedPath;
        }

        // Построение колонок
        public static ListView BuildColumnHeaders(ListView lv)
        {
            var columns = new ColumnHeader[5];

            columns[0] = new ColumnHeader {Text = "Файл", Width = 200};

            columns[1] = new ColumnHeader {Text = "Тип", Width = 40};

            columns[2] = new ColumnHeader {Text = "Размер", Width = 60};

            columns[3] = new ColumnHeader {Text = "Дата", Width = 100};

            columns[4] = new ColumnHeader {Text = "Путь", Width = 200};

            lv.Columns.AddRange(columns);

            return lv;
        }
    }
}