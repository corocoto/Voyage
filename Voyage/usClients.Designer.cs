namespace Voyage
{
    partial class usClients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usClients));
            this.addBtn = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.lCountOfClients = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pForBtn = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.photoOfClient = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.dtpBithday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AbroadDoc = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nameOfPhoto = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbSeries = new System.Windows.Forms.MaskedTextBox();
            this.tbNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbDocIssue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pForBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoOfClient)).BeginInit();
            this.SuspendLayout();
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
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Location = new System.Drawing.Point(229, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(163, 27);
            this.tbName.TabIndex = 2;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
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
            // pBorderRight
            // 
            this.pBorderRight.BackColor = System.Drawing.Color.Blue;
            this.pBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBorderRight.Location = new System.Drawing.Point(285, 0);
            this.pBorderRight.Name = "pBorderRight";
            this.pBorderRight.Size = new System.Drawing.Size(7, 886);
            this.pBorderRight.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearchClient);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lCount);
            this.panel1.Controls.Add(this.lCountOfClients);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 300);
            this.panel1.TabIndex = 4;
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearchClient.Location = new System.Drawing.Point(95, 119);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(163, 27);
            this.tbSearchClient.TabIndex = 34;
            this.tbSearchClient.Visible = false;
            this.tbSearchClient.TextChanged += new System.EventHandler(this.tbSearchClient_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Поиск";
            this.label11.Visible = false;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(71, 241);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(147, 23);
            this.lCount.TabIndex = 4;
            this.lCount.Text = "10000 человек";
            // 
            // lCountOfClients
            // 
            this.lCountOfClients.AutoSize = true;
            this.lCountOfClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountOfClients.Location = new System.Drawing.Point(16, 205);
            this.lCountOfClients.Name = "lCountOfClients";
            this.lCountOfClients.Size = new System.Drawing.Size(240, 21);
            this.lCountOfClients.TabIndex = 3;
            this.lCountOfClients.Text = "Общее количество клиентов:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 7);
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
            this.panel3.Size = new System.Drawing.Size(278, 49);
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
            this.excelBtn.Size = new System.Drawing.Size(103, 42);
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
            this.searchBtn.Location = new System.Drawing.Point(224, 4);
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
            this.panel2.Size = new System.Drawing.Size(278, 7);
            this.panel2.TabIndex = 0;
            // 
            // pForBtn
            // 
            this.pForBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pForBtn.Controls.Add(this.dgvClients);
            this.pForBtn.Controls.Add(this.panel1);
            this.pForBtn.Controls.Add(this.pBorderRight);
            this.pForBtn.Controls.Add(this.pBorderLeft);
            this.pForBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pForBtn.Location = new System.Drawing.Point(705, 0);
            this.pForBtn.Name = "pForBtn";
            this.pForBtn.Size = new System.Drawing.Size(292, 886);
            this.pForBtn.TabIndex = 3;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(7, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(278, 586);
            this.dgvClients.TabIndex = 5;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личные данные клиента";
            // 
            // photoOfClient
            // 
            this.photoOfClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photoOfClient.Location = new System.Drawing.Point(505, 106);
            this.photoOfClient.Name = "photoOfClient";
            this.photoOfClient.Size = new System.Drawing.Size(163, 141);
            this.photoOfClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoOfClient.TabIndex = 4;
            this.photoOfClient.TabStop = false;
            this.photoOfClient.DoubleClick += new System.EventHandler(this.photoOfClient_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSurname.Location = new System.Drawing.Point(229, 144);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(163, 27);
            this.tbSurname.TabIndex = 7;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPatronymic.Location = new System.Drawing.Point(229, 182);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(163, 27);
            this.tbPatronymic.TabIndex = 7;
            this.tbPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Док., удостоверяющий личность";
            // 
            // cbDoc
            // 
            this.cbDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoc.FormattingEnabled = true;
            this.cbDoc.Items.AddRange(new object[] {
            "паспорт",
            "загрант паспорт",
            "свидетельство о рождении"});
            this.cbDoc.Location = new System.Drawing.Point(505, 282);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(163, 29);
            this.cbDoc.TabIndex = 9;
            this.cbDoc.SelectedIndexChanged += new System.EventHandler(this.cbDoc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Серия";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Номер";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 710);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Дата выдачи";
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.Location = new System.Drawing.Point(229, 705);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(163, 27);
            this.dtpDateIssue.TabIndex = 13;
            this.dtpDateIssue.ValueChanged += new System.EventHandler(this.dtpDateIssue_ValueChanged);
            // 
            // dtpBithday
            // 
            this.dtpBithday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBithday.Location = new System.Drawing.Point(229, 220);
            this.dtpBithday.Name = "dtpBithday";
            this.dtpBithday.Size = new System.Drawing.Size(163, 27);
            this.dtpBithday.TabIndex = 15;
            this.dtpBithday.ValueChanged += new System.EventHandler(this.dtpBithday_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дата рождения";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Документ выдан...";
            // 
            // AbroadDoc
            // 
            this.AbroadDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbroadDoc.AutoSize = true;
            this.AbroadDoc.Location = new System.Drawing.Point(422, 707);
            this.AbroadDoc.Name = "AbroadDoc";
            this.AbroadDoc.Size = new System.Drawing.Size(246, 25);
            this.AbroadDoc.TabIndex = 18;
            this.AbroadDoc.Text = "Наличие загрант паспорта";
            this.AbroadDoc.UseVisualStyleBackColor = true;
            this.AbroadDoc.CheckedChanged += new System.EventHandler(this.AbroadDoc_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "client_default_photo.png");
            // 
            // nameOfPhoto
            // 
            this.nameOfPhoto.AutoSize = true;
            this.nameOfPhoto.Location = new System.Drawing.Point(418, 220);
            this.nameOfPhoto.Name = "nameOfPhoto";
            this.nameOfPhoto.Size = new System.Drawing.Size(66, 21);
            this.nameOfPhoto.TabIndex = 19;
            this.nameOfPhoto.Text = "label12";
            this.nameOfPhoto.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(581, 809);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 60);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbSeries
            // 
            this.tbSeries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSeries.Location = new System.Drawing.Point(229, 331);
            this.tbSeries.Mask = "0000";
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(163, 27);
            this.tbSeries.TabIndex = 21;
            this.tbSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeries_KeyPress);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumber.Location = new System.Drawing.Point(505, 334);
            this.tbNumber.Mask = "000000";
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(163, 27);
            this.tbNumber.TabIndex = 21;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // lbDocIssue
            // 
            this.lbDocIssue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDocIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDocIssue.Location = new System.Drawing.Point(75, 473);
            this.lbDocIssue.Multiline = true;
            this.lbDocIssue.Name = "lbDocIssue";
            this.lbDocIssue.Size = new System.Drawing.Size(593, 201);
            this.lbDocIssue.TabIndex = 22;
            this.lbDocIssue.TextChanged += new System.EventHandler(this.lbDocIssue_TextChanged);
            // 
            // usClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDocIssue);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbSeries);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameOfPhoto);
            this.Controls.Add(this.AbroadDoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBithday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.photoOfClient);
            this.Controls.Add(this.pForBtn);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usClients";
            this.Size = new System.Drawing.Size(997, 886);
            this.Load += new System.EventHandler(this.usClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pForBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoOfClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pForBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCountOfClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.PictureBox photoOfClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        private System.Windows.Forms.DateTimePicker dtpBithday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AbroadDoc;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label nameOfPhoto;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.MaskedTextBox tbSeries;
        private System.Windows.Forms.MaskedTextBox tbNumber;
        private System.Windows.Forms.TextBox lbDocIssue;
    }
}
