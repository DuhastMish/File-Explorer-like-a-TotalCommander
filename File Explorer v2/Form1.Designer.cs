namespace File_Explorer_v2
{
    partial class TotalCommander
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_left = new System.Windows.Forms.ListView();
            this.NameFl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeFl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeFl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathFl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_ListviewLeft = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_right = new System.Windows.Forms.ListView();
            this.NameFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_ListviewRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DiskRightPanel = new System.Windows.Forms.Panel();
            this.DiskLeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_cut = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.contextMenuStrip_ListviewLeft.SuspendLayout();
            this.contextMenuStrip_ListviewRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_left
            // 
            this.listView_left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFl,
            this.TypeFl,
            this.SizeFl,
            this.DateFl,
            this.PathFl});
            this.listView_left.ContextMenuStrip = this.contextMenuStrip_ListviewLeft;
            this.listView_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_left.FullRowSelect = true;
            this.listView_left.GridLines = true;
            this.listView_left.Location = new System.Drawing.Point(0, 0);
            this.listView_left.Name = "listView_left";
            this.listView_left.Size = new System.Drawing.Size(570, 421);
            this.listView_left.TabIndex = 0;
            this.listView_left.UseCompatibleStateImageBehavior = false;
            this.listView_left.View = System.Windows.Forms.View.Details;
            this.listView_left.ItemActivate += new System.EventHandler(this.listView_left_ItemActivate);
            // 
            // NameFl
            // 
            this.NameFl.Text = "Имя";
            // 
            // TypeFl
            // 
            this.TypeFl.Tag = "TypeFltag";
            this.TypeFl.Text = "Тип";
            // 
            // SizeFl
            // 
            this.SizeFl.Text = "Размер";
            // 
            // DateFl
            // 
            this.DateFl.Text = "Дата";
            // 
            // PathFl
            // 
            this.PathFl.Text = "Путь";
            // 
            // contextMenuStrip_ListviewLeft
            // 
            this.contextMenuStrip_ListviewLeft.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_ListviewLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_copy,
            this.ToolStripMenuItem_paste,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip_ListviewLeft.Name = "contextMenuStrip_Listview";
            this.contextMenuStrip_ListviewLeft.Size = new System.Drawing.Size(163, 76);
            // 
            // toolStripMenuItem_copy
            // 
            this.toolStripMenuItem_copy.Name = "toolStripMenuItem_copy";
            this.toolStripMenuItem_copy.Size = new System.Drawing.Size(162, 24);
            this.toolStripMenuItem_copy.Text = "Копировать";
            this.toolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItemLeft_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItem_paste.Text = "Вставить";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItemLeft_paste_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLeft_delete_Click);
            // 
            // listView_right
            // 
            this.listView_right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFr,
            this.TypeFr,
            this.SizeFr,
            this.DateFr,
            this.PathFr});
            this.listView_right.ContextMenuStrip = this.contextMenuStrip_ListviewRight;
            this.listView_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_right.FullRowSelect = true;
            this.listView_right.GridLines = true;
            this.listView_right.Location = new System.Drawing.Point(0, 0);
            this.listView_right.Name = "listView_right";
            this.listView_right.Size = new System.Drawing.Size(566, 421);
            this.listView_right.TabIndex = 1;
            this.listView_right.UseCompatibleStateImageBehavior = false;
            this.listView_right.View = System.Windows.Forms.View.Details;
            this.listView_right.ItemActivate += new System.EventHandler(this.listView_right_ItemActivate);
            // 
            // NameFr
            // 
            this.NameFr.Text = "Имя";
            this.NameFr.Width = 160;
            // 
            // TypeFr
            // 
            this.TypeFr.Text = "Тип";
            // 
            // SizeFr
            // 
            this.SizeFr.Text = "Размер";
            // 
            // DateFr
            // 
            this.DateFr.Text = "Дата";
            // 
            // PathFr
            // 
            this.PathFr.Text = "Путь";
            // 
            // contextMenuStrip_ListviewRight
            // 
            this.contextMenuStrip_ListviewRight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_ListviewRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip_ListviewRight.Name = "contextMenuStrip_ListviewRight";
            this.contextMenuStrip_ListviewRight.Size = new System.Drawing.Size(163, 76);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemRight_copy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemRight_paste_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItemRight_delete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 82);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView_left);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView_right);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 421);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.TabIndex = 2;
            // 
            // DiskRightPanel
            // 
            this.DiskRightPanel.Location = new System.Drawing.Point(590, 45);
            this.DiskRightPanel.Name = "DiskRightPanel";
            this.DiskRightPanel.Size = new System.Drawing.Size(558, 32);
            this.DiskRightPanel.TabIndex = 3;
            // 
            // DiskLeftPanel
            // 
            this.DiskLeftPanel.Location = new System.Drawing.Point(15, 45);
            this.DiskLeftPanel.Name = "DiskLeftPanel";
            this.DiskLeftPanel.Size = new System.Drawing.Size(565, 32);
            this.DiskLeftPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "C:\\";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(15, 514);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(100, 25);
            this.button_copy.TabIndex = 7;
            this.button_copy.Text = "Копировать";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.ToolStripMenuItemLeft_copy_Click);
            // 
            // button_paste
            // 
            this.button_paste.Location = new System.Drawing.Point(130, 514);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(100, 25);
            this.button_paste.TabIndex = 8;
            this.button_paste.Text = "Вставить";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.ToolStripMenuItemLeft_paste_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(245, 514);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(100, 25);
            this.button_move.TabIndex = 9;
            this.button_move.Text = "Переместить";
            this.button_move.UseVisualStyleBackColor = true;
            // 
            // button_cut
            // 
            this.button_cut.Location = new System.Drawing.Point(360, 514);
            this.button_cut.Name = "button_cut";
            this.button_cut.Size = new System.Drawing.Size(100, 25);
            this.button_cut.TabIndex = 10;
            this.button_cut.Text = "Вырезать";
            this.button_cut.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(475, 514);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 25);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // TotalCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 549);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_cut);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_paste);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiskLeftPanel);
            this.Controls.Add(this.DiskRightPanel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TotalCommander";
            this.Text = "Total Commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip_ListviewLeft.ResumeLayout(false);
            this.contextMenuStrip_ListviewRight.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_left;
        private System.Windows.Forms.ListView listView_right;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader NameFl;
        private System.Windows.Forms.ColumnHeader TypeFl;
        private System.Windows.Forms.ColumnHeader SizeFl;
        private System.Windows.Forms.ColumnHeader DateFl;
        private System.Windows.Forms.ColumnHeader NameFr;
        private System.Windows.Forms.ColumnHeader TypeFr;
        private System.Windows.Forms.ColumnHeader SizeFr;
        private System.Windows.Forms.ColumnHeader DateFr;
        private System.Windows.Forms.Panel DiskRightPanel;
        private System.Windows.Forms.Panel DiskLeftPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListviewLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.ColumnHeader PathFl;
        private System.Windows.Forms.ColumnHeader PathFr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListviewRight;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Button button_cut;
        private System.Windows.Forms.Button button_delete;
    }
}

