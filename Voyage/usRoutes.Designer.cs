namespace Voyage
{
    partial class usRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usRoutes));
            this.label9 = new System.Windows.Forms.Label();
            this.dateOfFly = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.nameOfRoute = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.lCountOfRoutes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSearchRoutes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.pForBtn = new System.Windows.Forms.Panel();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPlaneLogo = new System.Windows.Forms.PictureBox();
            this.mtbDays = new System.Windows.Forms.MaskedTextBox();
            this.mtbMoney = new System.Windows.Forms.MaskedTextBox();
            this.mtbSale = new System.Windows.Forms.MaskedTextBox();
            this.mtbReturn = new System.Windows.Forms.MaskedTextBox();
            this.cbAllPuncts = new System.Windows.Forms.ComboBox();
            this.cbAddPuncts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addPunct = new System.Windows.Forms.Button();
            this.delPunct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pForBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Срок пребывания (в днях)";
            // 
            // dateOfFly
            // 
            this.dateOfFly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfFly.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfFly.Location = new System.Drawing.Point(469, 489);
            this.dateOfFly.Name = "dateOfFly";
            this.dateOfFly.Size = new System.Drawing.Size(163, 27);
            this.dateOfFly.TabIndex = 36;
            this.dateOfFly.ValueChanged += new System.EventHandler(this.dateOfFly_ValueChanged);
            this.dateOfFly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDays_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Дата вылета";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Скидка (%)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Стоимость путевки (руб.)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Представитель";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Страна пребывания";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название маршрута";
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
            // nameOfRoute
            // 
            this.nameOfRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfRoute.Location = new System.Drawing.Point(469, 97);
            this.nameOfRoute.Name = "nameOfRoute";
            this.nameOfRoute.Size = new System.Drawing.Size(163, 27);
            this.nameOfRoute.TabIndex = 21;
            this.nameOfRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfRoute_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.lCount);
            this.panel1.Controls.Add(this.lCountOfRoutes);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbSearchRoutes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 300);
            this.panel1.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(103, 225);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 60);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(111, 184);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(54, 23);
            this.lCount.TabIndex = 4;
            this.lCount.Text = "3000";
            // 
            // lCountOfRoutes
            // 
            this.lCountOfRoutes.AutoSize = true;
            this.lCountOfRoutes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountOfRoutes.Location = new System.Drawing.Point(3, 163);
            this.lCountOfRoutes.Name = "lCountOfRoutes";
            this.lCountOfRoutes.Size = new System.Drawing.Size(263, 21);
            this.lCountOfRoutes.TabIndex = 3;
            this.lCountOfRoutes.Text = "Общее количество маршрутов:";
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
            // tbSearchRoutes
            // 
            this.tbSearchRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearchRoutes.Location = new System.Drawing.Point(103, 82);
            this.tbSearchRoutes.Name = "tbSearchRoutes";
            this.tbSearchRoutes.Size = new System.Drawing.Size(163, 27);
            this.tbSearchRoutes.TabIndex = 30;
            this.tbSearchRoutes.Visible = false;
            this.tbSearchRoutes.TextChanged += new System.EventHandler(this.tbSearchRoutes_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Поиск";
            this.label11.Visible = false;
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
            this.pForBtn.Controls.Add(this.dgvRoutes);
            this.pForBtn.Controls.Add(this.panel1);
            this.pForBtn.Controls.Add(this.pBorderRight);
            this.pForBtn.Controls.Add(this.pBorderLeft);
            this.pForBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pForBtn.Location = new System.Drawing.Point(705, 0);
            this.pForBtn.Name = "pForBtn";
            this.pForBtn.Size = new System.Drawing.Size(292, 886);
            this.pForBtn.TabIndex = 22;
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.AllowUserToAddRows = false;
            this.dgvRoutes.AllowUserToDeleteRows = false;
            this.dgvRoutes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoutes.Location = new System.Drawing.Point(7, 0);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.ReadOnly = true;
            this.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutes.Size = new System.Drawing.Size(278, 586);
            this.dgvRoutes.TabIndex = 5;
            this.dgvRoutes.SelectionChanged += new System.EventHandler(this.dgvRoutes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Данные о маршруте";
            // 
            // cbCountries
            // 
            this.cbCountries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Items.AddRange(new object[] {
            "Россия",
            "Германия",
            "Чехия",
            "Греция",
            "Италия",
            "Испания",
            "Нидерланды",
            "США"});
            this.cbCountries.Location = new System.Drawing.Point(469, 140);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(163, 29);
            this.cbCountries.TabIndex = 41;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(469, 277);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(163, 29);
            this.cbWorker.TabIndex = 41;
            this.cbWorker.SelectedIndexChanged += new System.EventHandler(this.cbWorker_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Неустойка (%)";
            // 
            // pbPlaneLogo
            // 
            this.pbPlaneLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPlaneLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbPlaneLogo.Image")));
            this.pbPlaneLogo.Location = new System.Drawing.Point(39, 692);
            this.pbPlaneLogo.Name = "pbPlaneLogo";
            this.pbPlaneLogo.Size = new System.Drawing.Size(593, 167);
            this.pbPlaneLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaneLogo.TabIndex = 42;
            this.pbPlaneLogo.TabStop = false;
            // 
            // mtbDays
            // 
            this.mtbDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbDays.Location = new System.Drawing.Point(469, 185);
            this.mtbDays.Mask = "00";
            this.mtbDays.Name = "mtbDays";
            this.mtbDays.Size = new System.Drawing.Size(163, 27);
            this.mtbDays.TabIndex = 43;
            this.mtbDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDays_KeyPress);
            // 
            // mtbMoney
            // 
            this.mtbMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbMoney.Location = new System.Drawing.Point(469, 322);
            this.mtbMoney.Mask = "000000";
            this.mtbMoney.Name = "mtbMoney";
            this.mtbMoney.Size = new System.Drawing.Size(163, 27);
            this.mtbMoney.TabIndex = 43;
            this.mtbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDays_KeyPress);
            // 
            // mtbSale
            // 
            this.mtbSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbSale.Location = new System.Drawing.Point(469, 366);
            this.mtbSale.Mask = "00";
            this.mtbSale.Name = "mtbSale";
            this.mtbSale.Size = new System.Drawing.Size(163, 27);
            this.mtbSale.TabIndex = 43;
            this.mtbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDays_KeyPress);
            // 
            // mtbReturn
            // 
            this.mtbReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbReturn.Location = new System.Drawing.Point(469, 409);
            this.mtbReturn.Mask = "0";
            this.mtbReturn.Name = "mtbReturn";
            this.mtbReturn.Size = new System.Drawing.Size(163, 27);
            this.mtbReturn.TabIndex = 43;
            this.mtbReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbDays_KeyPress);
            // 
            // cbAllPuncts
            // 
            this.cbAllPuncts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllPuncts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllPuncts.FormattingEnabled = true;
            this.cbAllPuncts.Location = new System.Drawing.Point(280, 586);
            this.cbAllPuncts.Name = "cbAllPuncts";
            this.cbAllPuncts.Size = new System.Drawing.Size(163, 29);
            this.cbAllPuncts.TabIndex = 41;
            // 
            // cbAddPuncts
            // 
            this.cbAddPuncts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAddPuncts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddPuncts.FormattingEnabled = true;
            this.cbAddPuncts.Location = new System.Drawing.Point(468, 586);
            this.cbAddPuncts.Name = "cbAddPuncts";
            this.cbAddPuncts.Size = new System.Drawing.Size(163, 29);
            this.cbAddPuncts.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Пункты маршрута";
            // 
            // addPunct
            // 
            this.addPunct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPunct.BackColor = System.Drawing.Color.DodgerBlue;
            this.addPunct.FlatAppearance.BorderSize = 0;
            this.addPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.addPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPunct.ForeColor = System.Drawing.Color.White;
            this.addPunct.Location = new System.Drawing.Point(525, 630);
            this.addPunct.Name = "addPunct";
            this.addPunct.Size = new System.Drawing.Size(50, 42);
            this.addPunct.TabIndex = 1;
            this.addPunct.Text = "+";
            this.addPunct.UseVisualStyleBackColor = false;
            this.addPunct.Click += new System.EventHandler(this.addPunct_Click);
            // 
            // delPunct
            // 
            this.delPunct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delPunct.BackColor = System.Drawing.Color.Crimson;
            this.delPunct.FlatAppearance.BorderSize = 0;
            this.delPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.delPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPunct.ForeColor = System.Drawing.Color.White;
            this.delPunct.Location = new System.Drawing.Point(581, 630);
            this.delPunct.Name = "delPunct";
            this.delPunct.Size = new System.Drawing.Size(50, 42);
            this.delPunct.TabIndex = 1;
            this.delPunct.Text = "-";
            this.delPunct.UseVisualStyleBackColor = false;
            this.delPunct.Click += new System.EventHandler(this.delPunct_Click);
            // 
            // usRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mtbReturn);
            this.Controls.Add(this.mtbSale);
            this.Controls.Add(this.delPunct);
            this.Controls.Add(this.mtbMoney);
            this.Controls.Add(this.addPunct);
            this.Controls.Add(this.mtbDays);
            this.Controls.Add(this.pbPlaneLogo);
            this.Controls.Add(this.cbAddPuncts);
            this.Controls.Add(this.cbAllPuncts);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateOfFly);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameOfRoute);
            this.Controls.Add(this.pForBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usRoutes";
            this.Size = new System.Drawing.Size(997, 886);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pForBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateOfFly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameOfRoute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lCountOfRoutes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearchRoutes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Panel pForBtn;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbPlaneLogo;
        private System.Windows.Forms.MaskedTextBox mtbDays;
        private System.Windows.Forms.MaskedTextBox mtbMoney;
        private System.Windows.Forms.MaskedTextBox mtbSale;
        private System.Windows.Forms.MaskedTextBox mtbReturn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox cbAllPuncts;
        private System.Windows.Forms.ComboBox cbAddPuncts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addPunct;
        private System.Windows.Forms.Button delPunct;
    }
}
