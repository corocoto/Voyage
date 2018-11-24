namespace Voyage
{
    partial class usPunct
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usPunct));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchPuncts = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.pForBtn = new System.Windows.Forms.Panel();
            this.dgvPuncts = new System.Windows.Forms.DataGridView();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tbPunct = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHotel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oneStar = new System.Windows.Forms.PictureBox();
            this.threeStars = new System.Windows.Forms.PictureBox();
            this.twoStars = new System.Windows.Forms.PictureBox();
            this.fiveStars = new System.Windows.Forms.PictureBox();
            this.fourStars = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbExcurse = new System.Windows.Forms.TextBox();
            this.lRaiting = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pForBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuncts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourStars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Пункт маршрута";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Страна";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пункт маршрута";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 42);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearchPuncts);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 300);
            this.panel1.TabIndex = 4;
            // 
            // tbSearchPuncts
            // 
            this.tbSearchPuncts.Location = new System.Drawing.Point(97, 89);
            this.tbSearchPuncts.Name = "tbSearchPuncts";
            this.tbSearchPuncts.Size = new System.Drawing.Size(197, 27);
            this.tbSearchPuncts.TabIndex = 37;
            this.tbSearchPuncts.Visible = false;
            this.tbSearchPuncts.TextChanged += new System.EventHandler(this.tbSearchPuncts_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(116, 194);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 60);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Поиск";
            this.label11.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 7);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.excelBtn);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.delBtn);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 49);
            this.panel3.TabIndex = 1;
            // 
            // excelBtn
            // 
            this.excelBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.excelBtn.FlatAppearance.BorderSize = 0;
            this.excelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.excelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelBtn.ForeColor = System.Drawing.Color.White;
            this.excelBtn.Location = new System.Drawing.Point(115, 4);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(134, 42);
            this.excelBtn.TabIndex = 1;
            this.excelBtn.Text = "Excel";
            this.excelBtn.UseVisualStyleBackColor = false;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Tomato;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(255, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 42);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Crimson;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(59, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(50, 42);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "-";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 7);
            this.panel2.TabIndex = 0;
            // 
            // pBorderRight
            // 
            this.pBorderRight.BackColor = System.Drawing.Color.Blue;
            this.pBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBorderRight.Location = new System.Drawing.Point(318, 0);
            this.pBorderRight.Name = "pBorderRight";
            this.pBorderRight.Size = new System.Drawing.Size(7, 886);
            this.pBorderRight.TabIndex = 4;
            // 
            // pBorderLeft
            // 
            this.pBorderLeft.BackColor = System.Drawing.Color.Blue;
            this.pBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.pBorderLeft.Name = "pBorderLeft";
            this.pBorderLeft.Size = new System.Drawing.Size(7, 886);
            this.pBorderLeft.TabIndex = 0;
            // 
            // pForBtn
            // 
            this.pForBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pForBtn.Controls.Add(this.dgvPuncts);
            this.pForBtn.Controls.Add(this.panel1);
            this.pForBtn.Controls.Add(this.pBorderRight);
            this.pForBtn.Controls.Add(this.pBorderLeft);
            this.pForBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pForBtn.Location = new System.Drawing.Point(672, 0);
            this.pForBtn.Name = "pForBtn";
            this.pForBtn.Size = new System.Drawing.Size(325, 886);
            this.pForBtn.TabIndex = 25;
            // 
            // dgvPuncts
            // 
            this.dgvPuncts.AllowUserToAddRows = false;
            this.dgvPuncts.AllowUserToDeleteRows = false;
            this.dgvPuncts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPuncts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuncts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuncts.Location = new System.Drawing.Point(7, 0);
            this.dgvPuncts.Name = "dgvPuncts";
            this.dgvPuncts.ReadOnly = true;
            this.dgvPuncts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuncts.Size = new System.Drawing.Size(311, 586);
            this.dgvPuncts.TabIndex = 5;
            this.dgvPuncts.SelectionChanged += new System.EventHandler(this.dgvPuncts_SelectionChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Россия",
            "Германия",
            "Чехия",
            "Греция",
            "Италия",
            "Испания",
            "Нидерланды",
            "США"});
            this.cbCountry.Location = new System.Drawing.Point(193, 103);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(163, 29);
            this.cbCountry.TabIndex = 45;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // tbPunct
            // 
            this.tbPunct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPunct.Location = new System.Drawing.Point(193, 147);
            this.tbPunct.Name = "tbPunct";
            this.tbPunct.Size = new System.Drawing.Size(163, 27);
            this.tbPunct.TabIndex = 46;
            this.tbPunct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPunct_KeyPress);
            // 
            // dateStart
            // 
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(193, 233);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(163, 27);
            this.dateStart.TabIndex = 47;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(193, 276);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(163, 27);
            this.dateEnd.TabIndex = 48;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Название отеля";
            // 
            // tbHotel
            // 
            this.tbHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHotel.Location = new System.Drawing.Point(193, 193);
            this.tbHotel.Name = "tbHotel";
            this.tbHotel.Size = new System.Drawing.Size(163, 27);
            this.tbHotel.TabIndex = 46;
            this.tbHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHotel_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Дата прибытия";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Дата убытия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Класс гостиницы";
            // 
            // oneStar
            // 
            this.oneStar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneStar.Image = ((System.Drawing.Image)(resources.GetObject("oneStar.Image")));
            this.oneStar.Location = new System.Drawing.Point(39, 451);
            this.oneStar.Name = "oneStar";
            this.oneStar.Size = new System.Drawing.Size(50, 50);
            this.oneStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oneStar.TabIndex = 50;
            this.oneStar.TabStop = false;
            this.oneStar.Click += new System.EventHandler(this.oneStar_Click);
            this.oneStar.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.oneStar.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // threeStars
            // 
            this.threeStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeStars.Image = ((System.Drawing.Image)(resources.GetObject("threeStars.Image")));
            this.threeStars.Location = new System.Drawing.Point(169, 451);
            this.threeStars.Name = "threeStars";
            this.threeStars.Size = new System.Drawing.Size(50, 50);
            this.threeStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeStars.TabIndex = 50;
            this.threeStars.TabStop = false;
            this.threeStars.Click += new System.EventHandler(this.oneStar_Click);
            this.threeStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.threeStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // twoStars
            // 
            this.twoStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoStars.Image = ((System.Drawing.Image)(resources.GetObject("twoStars.Image")));
            this.twoStars.Location = new System.Drawing.Point(104, 451);
            this.twoStars.Name = "twoStars";
            this.twoStars.Size = new System.Drawing.Size(50, 50);
            this.twoStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoStars.TabIndex = 50;
            this.twoStars.TabStop = false;
            this.twoStars.Click += new System.EventHandler(this.oneStar_Click);
            this.twoStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.twoStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // fiveStars
            // 
            this.fiveStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveStars.Image = ((System.Drawing.Image)(resources.GetObject("fiveStars.Image")));
            this.fiveStars.Location = new System.Drawing.Point(300, 451);
            this.fiveStars.Name = "fiveStars";
            this.fiveStars.Size = new System.Drawing.Size(50, 50);
            this.fiveStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiveStars.TabIndex = 50;
            this.fiveStars.TabStop = false;
            this.fiveStars.Click += new System.EventHandler(this.oneStar_Click);
            this.fiveStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.fiveStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // fourStars
            // 
            this.fourStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourStars.Image = ((System.Drawing.Image)(resources.GetObject("fourStars.Image")));
            this.fourStars.Location = new System.Drawing.Point(234, 451);
            this.fourStars.Name = "fourStars";
            this.fourStars.Size = new System.Drawing.Size(50, 50);
            this.fourStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourStars.TabIndex = 50;
            this.fourStars.TabStop = false;
            this.fourStars.Click += new System.EventHandler(this.oneStar_Click);
            this.fourStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.fourStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Экскурсионная программа";
            // 
            // tbExcurse
            // 
            this.tbExcurse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExcurse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExcurse.Location = new System.Drawing.Point(39, 629);
            this.tbExcurse.Multiline = true;
            this.tbExcurse.Name = "tbExcurse";
            this.tbExcurse.Size = new System.Drawing.Size(602, 201);
            this.tbExcurse.TabIndex = 51;
            this.tbExcurse.TextChanged += new System.EventHandler(this.tbExcurse_TextChanged);
            // 
            // lRaiting
            // 
            this.lRaiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRaiting.AutoSize = true;
            this.lRaiting.Location = new System.Drawing.Point(398, 410);
            this.lRaiting.Name = "lRaiting";
            this.lRaiting.Size = new System.Drawing.Size(19, 21);
            this.lRaiting.TabIndex = 27;
            this.lRaiting.Text = "0";
            this.lRaiting.Visible = false;
            this.lRaiting.TextChanged += new System.EventHandler(this.lRaiting_TextChanged);
            // 
            // usPunct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbExcurse);
            this.Controls.Add(this.fourStars);
            this.Controls.Add(this.fiveStars);
            this.Controls.Add(this.twoStars);
            this.Controls.Add(this.threeStars);
            this.Controls.Add(this.oneStar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.tbHotel);
            this.Controls.Add(this.tbPunct);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lRaiting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pForBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usPunct";
            this.Size = new System.Drawing.Size(997, 886);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pForBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuncts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Panel pForBtn;
        private System.Windows.Forms.DataGridView dgvPuncts;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox tbPunct;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHotel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox oneStar;
        private System.Windows.Forms.PictureBox threeStars;
        private System.Windows.Forms.PictureBox twoStars;
        private System.Windows.Forms.PictureBox fiveStars;
        private System.Windows.Forms.PictureBox fourStars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbExcurse;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lRaiting;
        private System.Windows.Forms.TextBox tbSearchPuncts;
    }
}
