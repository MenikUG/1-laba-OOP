namespace _1_laba_OOP
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Russia"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "China"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Belarusian"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "German"}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "America"}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Hello = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.kolich = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.poleinput = new System.Windows.Forms.TextBox();
            this.polerepeat = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.pagelist = new System.Windows.Forms.TabControl();
            this.pagelist_1 = new System.Windows.Forms.TabPage();
            this.pbfull = new System.Windows.Forms.Label();
            this.pagelist_2 = new System.Windows.Forms.TabPage();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.CHECK = new System.Windows.Forms.Button();
            this.label_Task = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.pagelist_3 = new System.Windows.Forms.TabPage();
            this.text4 = new System.Windows.Forms.Label();
            this.listcolor = new System.Windows.Forms.ComboBox();
            this.countrylist = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.text6 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.info_countrylist = new System.Windows.Forms.ToolTip(this.components);
            this.main = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Galka = new System.Windows.Forms.ToolStripMenuItem();
            this.Komplekt = new System.Windows.Forms.ToolStripMenuItem();
            this.CPU = new System.Windows.Forms.ToolStripMenuItem();
            this.GPU = new System.Windows.Forms.ToolStripMenuItem();
            this.pagelist.SuspendLayout();
            this.pagelist_1.SuspendLayout();
            this.pagelist_2.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Hello
            // 
            this.button_Hello.Location = new System.Drawing.Point(12, 40);
            this.button_Hello.Name = "button_Hello";
            this.button_Hello.Size = new System.Drawing.Size(75, 28);
            this.button_Hello.TabIndex = 0;
            this.button_Hello.Text = "Hello";
            this.button_Hello.UseVisualStyleBackColor = true;
            this.button_Hello.Click += new System.EventHandler(this.button_Hello_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.Control;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Location = new System.Drawing.Point(12, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(209, 15);
            this.text.TabIndex = 1;
            this.text.Text = "Cчётчик нажатий кнопки Hello : ";
            // 
            // kolich
            // 
            this.kolich.AutoSize = true;
            this.kolich.Location = new System.Drawing.Point(216, 12);
            this.kolich.Name = "kolich";
            this.kolich.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kolich.Size = new System.Drawing.Size(16, 17);
            this.kolich.TabIndex = 2;
            this.kolich.Text = "0";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text2.Location = new System.Drawing.Point(12, 92);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(137, 19);
            this.text2.TabIndex = 3;
            this.text2.Text = "Введите что-либо: ";
            // 
            // poleinput
            // 
            this.poleinput.Location = new System.Drawing.Point(155, 89);
            this.poleinput.Name = "poleinput";
            this.poleinput.Size = new System.Drawing.Size(101, 22);
            this.poleinput.TabIndex = 4;
            this.poleinput.TextChanged += new System.EventHandler(this.poleinput_TextChanged);
            // 
            // polerepeat
            // 
            this.polerepeat.Location = new System.Drawing.Point(156, 122);
            this.polerepeat.Name = "polerepeat";
            this.polerepeat.Size = new System.Drawing.Size(100, 22);
            this.polerepeat.TabIndex = 5;
            this.polerepeat.TextChanged += new System.EventHandler(this.polerepeat_TextChanged);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.SystemColors.Control;
            this.text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text3.Location = new System.Drawing.Point(12, 122);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(79, 19);
            this.text3.TabIndex = 6;
            this.text3.Text = "Вы ввели: ";
            // 
            // pagelist
            // 
            this.pagelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagelist.Controls.Add(this.pagelist_1);
            this.pagelist.Controls.Add(this.pagelist_2);
            this.pagelist.Controls.Add(this.pagelist_3);
            this.pagelist.Location = new System.Drawing.Point(313, 12);
            this.pagelist.Name = "pagelist";
            this.pagelist.SelectedIndex = 0;
            this.pagelist.Size = new System.Drawing.Size(652, 531);
            this.pagelist.TabIndex = 7;
            // 
            // pagelist_1
            // 
            this.pagelist_1.BackColor = System.Drawing.SystemColors.Window;
            this.pagelist_1.Controls.Add(this.pbfull);
            this.pagelist_1.Location = new System.Drawing.Point(4, 25);
            this.pagelist_1.Name = "pagelist_1";
            this.pagelist_1.Padding = new System.Windows.Forms.Padding(3);
            this.pagelist_1.Size = new System.Drawing.Size(644, 502);
            this.pagelist_1.TabIndex = 0;
            this.pagelist_1.Text = "Color list";
            // 
            // pbfull
            // 
            this.pbfull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbfull.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pbfull.Location = new System.Drawing.Point(3, 12);
            this.pbfull.Name = "pbfull";
            this.pbfull.Size = new System.Drawing.Size(632, 390);
            this.pbfull.TabIndex = 14;
            this.pbfull.Text = "ProgressBar Заполнен\r\n\r\nнажмите на кнопку Hello либо Сброс";
            this.pbfull.Visible = false;
            // 
            // pagelist_2
            // 
            this.pagelist_2.BackColor = System.Drawing.Color.Gray;
            this.pagelist_2.Controls.Add(this.Menu);
            this.pagelist_2.Controls.Add(this.CHECK);
            this.pagelist_2.Controls.Add(this.label_Task);
            this.pagelist_2.Controls.Add(this.picture);
            this.pagelist_2.Controls.Add(this.checkedListBox);
            this.pagelist_2.Location = new System.Drawing.Point(4, 25);
            this.pagelist_2.Name = "pagelist_2";
            this.pagelist_2.Padding = new System.Windows.Forms.Padding(3);
            this.pagelist_2.Size = new System.Drawing.Size(644, 502);
            this.pagelist_2.TabIndex = 1;
            this.pagelist_2.Text = "Gray list";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main});
            this.Menu.Location = new System.Drawing.Point(3, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(638, 28);
            this.Menu.TabIndex = 0;
            // 
            // CHECK
            // 
            this.CHECK.Location = new System.Drawing.Point(365, 405);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(273, 80);
            this.CHECK.TabIndex = 16;
            this.CHECK.Text = "Проверить выполнение заданий";
            this.CHECK.UseVisualStyleBackColor = true;
            this.CHECK.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // label_Task
            // 
            this.label_Task.AutoSize = true;
            this.label_Task.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Task.Location = new System.Drawing.Point(3, 355);
            this.label_Task.Name = "label_Task";
            this.label_Task.Size = new System.Drawing.Size(164, 38);
            this.label_Task.TabIndex = 15;
            this.label_Task.Text = "Задания:";
            this.label_Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Location = new System.Drawing.Point(3, 36);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(638, 324);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 14;
            this.picture.TabStop = false;
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.checkedListBox.Items.AddRange(new object[] {
            "Открыть пункт Главное ",
            "Поставить галочку в пункте Информация",
            "Поставить галочку в пункте Галка",
            "Посмотреть фото Процессора",
            "Посмотреть фото Видеокарты"});
            this.checkedListBox.Location = new System.Drawing.Point(3, 393);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox.Size = new System.Drawing.Size(638, 106);
            this.checkedListBox.TabIndex = 1;
            this.checkedListBox.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // pagelist_3
            // 
            this.pagelist_3.Location = new System.Drawing.Point(4, 25);
            this.pagelist_3.Name = "pagelist_3";
            this.pagelist_3.Size = new System.Drawing.Size(644, 502);
            this.pagelist_3.TabIndex = 2;
            this.pagelist_3.Text = "White list";
            this.pagelist_3.UseVisualStyleBackColor = true;
            // 
            // text4
            // 
            this.text4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.text4.Location = new System.Drawing.Point(9, 150);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(118, 60);
            this.text4.TabIndex = 9;
            this.text4.Text = "Выберите цвет для фона у цветного листа";
            // 
            // listcolor
            // 
            this.listcolor.FormattingEnabled = true;
            this.listcolor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listcolor.Items.AddRange(new object[] {
            "Красный",
            "Оранжевый",
            "Жёлтый",
            "Зелёный",
            "Голубой",
            "Синий",
            "Фиолетовый",
            "Белый",
            "Черный",
            "Серый"});
            this.listcolor.Location = new System.Drawing.Point(139, 165);
            this.listcolor.Name = "listcolor";
            this.listcolor.Size = new System.Drawing.Size(121, 24);
            this.listcolor.TabIndex = 10;
            this.listcolor.SelectedIndexChanged += new System.EventHandler(this.listcolor_SelectedIndexChanged);
            // 
            // countrylist
            // 
            this.countrylist.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.countrylist.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.countrylist.HideSelection = false;
            this.countrylist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.countrylist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.countrylist.LargeImageList = this.imageList1;
            this.countrylist.Location = new System.Drawing.Point(12, 241);
            this.countrylist.Name = "countrylist";
            this.countrylist.Size = new System.Drawing.Size(244, 121);
            this.countrylist.TabIndex = 11;
            this.info_countrylist.SetToolTip(this.countrylist, "Чтобы перейти на сайт в википедии нажмите на страну");
            this.countrylist.UseCompatibleStateImageBehavior = false;
            this.countrylist.SelectedIndexChanged += new System.EventHandler(this.countrylist_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Russia.jpg");
            this.imageList1.Images.SetKeyName(1, "china.jpg");
            this.imageList1.Images.SetKeyName(2, "belarus.png");
            this.imageList1.Images.SetKeyName(3, "Germany.jpg");
            this.imageList1.Images.SetKeyName(4, "America.jpg");
            // 
            // text6
            // 
            this.text6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text6.Location = new System.Drawing.Point(12, 210);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(244, 28);
            this.text6.TabIndex = 12;
            this.text6.Text = "Узнать больше о стране";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(154, 40);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(78, 28);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(238, 12);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(69, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // main
            // 
            this.main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info,
            this.Galka,
            this.Komplekt});
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(80, 24);
            this.main.Text = "Главное";
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // Info
            // 
            this.Info.CheckOnClick = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(224, 26);
            this.Info.Text = "Информация";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Galka
            // 
            this.Galka.CheckOnClick = true;
            this.Galka.Name = "Galka";
            this.Galka.Size = new System.Drawing.Size(224, 26);
            this.Galka.Text = "Галка";
            this.Galka.Click += new System.EventHandler(this.Galka_Click);
            // 
            // Komplekt
            // 
            this.Komplekt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CPU,
            this.GPU});
            this.Komplekt.Name = "Komplekt";
            this.Komplekt.Size = new System.Drawing.Size(224, 26);
            this.Komplekt.Text = "Комплектующие";
            // 
            // CPU
            // 
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(224, 26);
            this.CPU.Text = "Процессор";
            this.CPU.Click += new System.EventHandler(this.CPU_Click);
            // 
            // GPU
            // 
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(224, 26);
            this.GPU.Text = "Видеокарта";
            this.GPU.Click += new System.EventHandler(this.GPU_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 555);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.poleinput);
            this.Controls.Add(this.countrylist);
            this.Controls.Add(this.listcolor);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.pagelist);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.polerepeat);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.kolich);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button_Hello);
            this.Name = "MainForm";
            this.Text = "1laba";
            this.pagelist.ResumeLayout(false);
            this.pagelist_1.ResumeLayout(false);
            this.pagelist_2.ResumeLayout(false);
            this.pagelist_2.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Hello;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label kolich;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox poleinput;
        private System.Windows.Forms.TextBox polerepeat;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TabControl pagelist;
        public System.Windows.Forms.TabPage pagelist_1;
        public System.Windows.Forms.TabPage pagelist_2;
        public System.Windows.Forms.TabPage pagelist_3;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.ComboBox listcolor;
        private System.Windows.Forms.ListView countrylist;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label pbfull;
        private System.Windows.Forms.ToolTip info_countrylist;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label_Task;
        private System.Windows.Forms.Button CHECK;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem main;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem Galka;
        private System.Windows.Forms.ToolStripMenuItem Komplekt;
        private System.Windows.Forms.ToolStripMenuItem CPU;
        private System.Windows.Forms.ToolStripMenuItem GPU;
    }
}

