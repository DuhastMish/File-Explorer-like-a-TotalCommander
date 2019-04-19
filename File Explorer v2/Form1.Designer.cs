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
            this.toolStripMenuItem_move = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_right = new System.Windows.Forms.ListView();
            this.NameFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathFr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_ListviewRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_moveR = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПапкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DiskLeftPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DiskRightPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip_ListviewLeft.SuspendLayout();
            this.contextMenuStrip_ListviewRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_left
            // 
            this.listView_left.AllowDrop = true;
            this.listView_left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFl,
            this.TypeFl,
            this.SizeFl,
            this.DateFl,
            this.PathFl});
            this.listView_left.ContextMenuStrip = this.contextMenuStrip_ListviewLeft;
            this.listView_left.FullRowSelect = true;
            this.listView_left.GridLines = true;
            this.listView_left.Location = new System.Drawing.Point(0, 69);
            this.listView_left.Name = "listView_left";
            this.listView_left.Size = new System.Drawing.Size(415, 447);
            this.listView_left.TabIndex = 0;
            this.listView_left.UseCompatibleStateImageBehavior = false;
            this.listView_left.View = System.Windows.Forms.View.Details;
            this.listView_left.ItemActivate += new System.EventHandler(this.listView_left_ItemActivate);
            this.listView_left.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_left_ItemDrag);
            this.listView_left.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_left_DragDrop);
            this.listView_left.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DragOver);
            this.listView_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalCommander_KeyDown);
            this.listView_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_left_MouseDown);
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
            this.toolStripMenuItem_move,
            this.удалитьToolStripMenuItem,
            this.создатьПапкуToolStripMenuItem});
            this.contextMenuStrip_ListviewLeft.Name = "contextMenuStrip_Listview";
            this.contextMenuStrip_ListviewLeft.Size = new System.Drawing.Size(178, 124);
            // 
            // toolStripMenuItem_copy
            // 
            this.toolStripMenuItem_copy.Name = "toolStripMenuItem_copy";
            this.toolStripMenuItem_copy.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_copy.Text = "Копировать";
            this.toolStripMenuItem_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(177, 24);
            this.ToolStripMenuItem_paste.Text = "Вставить";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // toolStripMenuItem_move
            // 
            this.toolStripMenuItem_move.Name = "toolStripMenuItem_move";
            this.toolStripMenuItem_move.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_move.Text = "Переместить";
            this.toolStripMenuItem_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            this.создатьПапкуToolStripMenuItem.Click += new System.EventHandler(this.button_create_Click);
            // 
            // listView_right
            // 
            this.listView_right.AllowDrop = true;
            this.listView_right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFr,
            this.TypeFr,
            this.SizeFr,
            this.DateFr,
            this.PathFr});
            this.listView_right.ContextMenuStrip = this.contextMenuStrip_ListviewRight;
            this.listView_right.FullRowSelect = true;
            this.listView_right.GridLines = true;
            this.listView_right.Location = new System.Drawing.Point(0, 69);
            this.listView_right.Name = "listView_right";
            this.listView_right.Size = new System.Drawing.Size(414, 447);
            this.listView_right.TabIndex = 1;
            this.listView_right.UseCompatibleStateImageBehavior = false;
            this.listView_right.View = System.Windows.Forms.View.Details;
            this.listView_right.ItemActivate += new System.EventHandler(this.listView_right_ItemActivate);
            this.listView_right.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_right_ItemDrag);
            this.listView_right.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_right_DragDrop);
            this.listView_right.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DragOver);
            this.listView_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalCommander_KeyDown);
            this.listView_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_right_MouseDown);
            // 
            // NameFr
            // 
            this.NameFr.Text = "Имя";
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
            this.toolStripMenuItem_moveR,
            this.удалитьToolStripMenuItem1,
            this.создатьПапкуToolStripMenuItem1});
            this.contextMenuStrip_ListviewRight.Name = "contextMenuStrip_ListviewRight";
            this.contextMenuStrip_ListviewRight.Size = new System.Drawing.Size(178, 124);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // toolStripMenuItem_moveR
            // 
            this.toolStripMenuItem_moveR.Name = "toolStripMenuItem_moveR";
            this.toolStripMenuItem_moveR.Size = new System.Drawing.Size(177, 24);
            this.toolStripMenuItem_moveR.Text = "Переместить";
            this.toolStripMenuItem_moveR.Click += new System.EventHandler(this.button_move_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // создатьПапкуToolStripMenuItem1
            // 
            this.создатьПапкуToolStripMenuItem1.Name = "создатьПапкуToolStripMenuItem1";
            this.создатьПапкуToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.создатьПапкуToolStripMenuItem1.Text = "Создать папку";
            this.создатьПапкуToolStripMenuItem1.Click += new System.EventHandler(this.button_create_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView_left);
            this.splitContainer1.Panel1.Controls.Add(this.DiskLeftPanel);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView_right);
            this.splitContainer1.Panel2.Controls.Add(this.DiskRightPanel);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(834, 516);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // DiskLeftPanel
            // 
            this.DiskLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiskLeftPanel.Location = new System.Drawing.Point(5, 31);
            this.DiskLeftPanel.Name = "DiskLeftPanel";
            this.DiskLeftPanel.Size = new System.Drawing.Size(409, 32);
            this.DiskLeftPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "C:\\";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DiskRightPanel
            // 
            this.DiskRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiskRightPanel.Location = new System.Drawing.Point(3, 31);
            this.DiskRightPanel.Name = "DiskRightPanel";
            this.DiskRightPanel.Size = new System.Drawing.Size(410, 32);
            this.DiskRightPanel.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(409, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "C:\\";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_copy
            // 
            this.button_copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_copy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_copy.Location = new System.Drawing.Point(3, 3);
            this.button_copy.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_copy.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(150, 25);
            this.button_copy.TabIndex = 7;
            this.button_copy.Text = "Копировать (F5)";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_paste
            // 
            this.button_paste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_paste.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_paste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_paste.Location = new System.Drawing.Point(166, 3);
            this.button_paste.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_paste.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(150, 25);
            this.button_paste.TabIndex = 8;
            this.button_paste.Text = "Вставить (F6)";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // button_move
            // 
            this.button_move.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_move.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_move.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_move.Location = new System.Drawing.Point(329, 3);
            this.button_move.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_move.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(150, 25);
            this.button_move.TabIndex = 9;
            this.button_move.Text = "Переместить (F7)";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Location = new System.Drawing.Point(492, 3);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_delete.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(150, 25);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Удалить (F8)";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_create
            // 
            this.button_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_create.Location = new System.Drawing.Point(655, 3);
            this.button_create.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_create.MinimumSize = new System.Drawing.Size(50, 20);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(150, 25);
            this.button_create.TabIndex = 14;
            this.button_create.Text = "Создать папку (F9)";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_copy);
            this.panel1.Controls.Add(this.button_paste);
            this.panel1.Controls.Add(this.button_create);
            this.panel1.Controls.Add(this.button_move);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Location = new System.Drawing.Point(10, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 33);
            this.panel1.TabIndex = 3;
            // 
            // TotalCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "TotalCommander";
            this.Text = "Total Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TotalCommander_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.TotalCommander_Resize);
            this.contextMenuStrip_ListviewLeft.ResumeLayout(false);
            this.contextMenuStrip_ListviewRight.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.ColumnHeader PathFl;
        private System.Windows.Forms.ColumnHeader PathFr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListviewRight;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ListView listView_left;
        private System.Windows.Forms.ListView listView_right;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListviewLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_move;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_moveR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
    }
}

