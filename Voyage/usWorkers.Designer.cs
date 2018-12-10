namespace Voyage
{
    partial class usWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usWorkers));
            this.AbroadDoc = new System.Windows.Forms.CheckBox();
            this.dtpBithday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pForBtn = new System.Windows.Forms.Panel();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.photoOfWorker = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nameOfPhoto = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pForBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoOfWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AbroadDoc
            // 
            this.AbroadDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbroadDoc.AutoSize = true;
            this.AbroadDoc.Location = new System.Drawing.Point(359, 366);
            this.AbroadDoc.Name = "AbroadDoc";
            this.AbroadDoc.Size = new System.Drawing.Size(246, 25);
            this.AbroadDoc.TabIndex = 42;
            this.AbroadDoc.Text = "Наличие загрант паспорта";
            this.AbroadDoc.UseVisualStyleBackColor = true;
            this.AbroadDoc.CheckedChanged += new System.EventHandler(this.AbroadDoc_CheckedChanged);
            // 
            // dtpBithday
            // 
            this.dtpBithday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBithday.Location = new System.Drawing.Point(39, 307);
            this.dtpBithday.Name = "dtpBithday";
            this.dtpBithday.Size = new System.Drawing.Size(566, 27);
            this.dtpBithday.TabIndex = 39;
            this.dtpBithday.ValueChanged += new System.EventHandler(this.dtpBithday_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Дата рождения";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPatronymic.Location = new System.Drawing.Point(180, 191);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(163, 27);
            this.tbPatronymic.TabIndex = 30;
            this.tbPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Отчество";
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSurname.Location = new System.Drawing.Point(180, 144);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(163, 27);
            this.tbSurname.TabIndex = 29;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Имя";
            // 
            // groupBtn
            // 
            this.groupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBtn.BackColor = System.Drawing.Color.Transparent;
            this.groupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBtn.BackgroundImage")));
            this.groupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBtn.FlatAppearance.BorderSize = 0;
            this.groupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.groupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBtn.ForeColor = System.Drawing.Color.White;
            this.groupBtn.Location = new System.Drawing.Point(588, 782);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(118, 104);
            this.groupBtn.TabIndex = 21;
            this.groupBtn.UseVisualStyleBackColor = false;
            this.groupBtn.Visible = false;
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
            this.tbName.Location = new System.Drawing.Point(180, 103);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(163, 27);
            this.tbName.TabIndex = 22;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
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
            this.saveBtn.Location = new System.Drawing.Point(106, 214);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 60);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearch.Location = new System.Drawing.Point(91, 94);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(163, 27);
            this.tbSearch.TabIndex = 34;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 97);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Представители компании";
            // 
            // pForBtn
            // 
            this.pForBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pForBtn.Controls.Add(this.dgvWorkers);
            this.pForBtn.Controls.Add(this.panel1);
            this.pForBtn.Controls.Add(this.pBorderRight);
            this.pForBtn.Controls.Add(this.pBorderLeft);
            this.pForBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pForBtn.Location = new System.Drawing.Point(705, 0);
            this.pForBtn.Name = "pForBtn";
            this.pForBtn.Size = new System.Drawing.Size(292, 886);
            this.pForBtn.TabIndex = 23;
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkers.Location = new System.Drawing.Point(7, 0);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(278, 586);
            this.dgvWorkers.TabIndex = 5;
            this.dgvWorkers.SelectionChanged += new System.EventHandler(this.dgvWorkers_SelectionChanged);
            // 
            // photoOfWorker
            // 
            this.photoOfWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photoOfWorker.Location = new System.Drawing.Point(475, 103);
            this.photoOfWorker.Name = "photoOfWorker";
            this.photoOfWorker.Size = new System.Drawing.Size(130, 115);
            this.photoOfWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoOfWorker.TabIndex = 43;
            this.photoOfWorker.TabStop = false;
            this.photoOfWorker.DoubleClick += new System.EventHandler(this.photoOfWorker_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 532);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(401, 532);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // nameOfPhoto
            // 
            this.nameOfPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfPhoto.AutoSize = true;
            this.nameOfPhoto.Location = new System.Drawing.Point(513, 233);
            this.nameOfPhoto.Name = "nameOfPhoto";
            this.nameOfPhoto.Size = new System.Drawing.Size(57, 21);
            this.nameOfPhoto.TabIndex = 44;
            this.nameOfPhoto.Text = "label5";
            this.nameOfPhoto.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "client_default_photo.png");
            // 
            // usWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nameOfPhoto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.photoOfWorker);
            this.Controls.Add(this.AbroadDoc);
            this.Controls.Add(this.dtpBithday);
            this.Controls.Add(this.groupBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pForBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usWorkers";
            this.Size = new System.Drawing.Size(997, 886);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pForBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoOfWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AbroadDoc;
        private System.Windows.Forms.DateTimePicker dtpBithday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pForBtn;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.PictureBox photoOfWorker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label nameOfPhoto;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}
