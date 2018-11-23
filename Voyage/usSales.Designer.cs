namespace Voyage
{
    partial class usSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usSales));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbNameOfRoute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewClientsWithSales = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCountOfPeople = new System.Windows.Forms.NumericUpDown();
            this.tbCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скидки для наших клиентов";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbNameOfRoute
            // 
            this.cbNameOfRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNameOfRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameOfRoute.FormattingEnabled = true;
            this.cbNameOfRoute.Location = new System.Drawing.Point(50, 210);
            this.cbNameOfRoute.Name = "cbNameOfRoute";
            this.cbNameOfRoute.Size = new System.Drawing.Size(275, 29);
            this.cbNameOfRoute.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название маршрута";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 88);
            this.label3.TabIndex = 3;
            this.label3.Text = "При покупке билетов группой от 3-ех и более человек предоставляется скидка ... ка" +
    "ждому";
            // 
            // addNewClientsWithSales
            // 
            this.addNewClientsWithSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewClientsWithSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewClientsWithSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewClientsWithSales.Image = ((System.Drawing.Image)(resources.GetObject("addNewClientsWithSales.Image")));
            this.addNewClientsWithSales.Location = new System.Drawing.Point(50, 572);
            this.addNewClientsWithSales.Name = "addNewClientsWithSales";
            this.addNewClientsWithSales.Size = new System.Drawing.Size(275, 77);
            this.addNewClientsWithSales.TabIndex = 5;
            this.addNewClientsWithSales.Text = "     Оформить заказ";
            this.addNewClientsWithSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewClientsWithSales.UseVisualStyleBackColor = true;
            this.addNewClientsWithSales.Click += new System.EventHandler(this.addNewClientsWithSales_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 769);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 92);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиенты могут оплачивать билеты не только наличными, но и следующими типами банко" +
    "вских карт";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(552, 759);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(708, 759);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(861, 759);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Количество человек в группе";
            // 
            // nudCountOfPeople
            // 
            this.nudCountOfPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCountOfPeople.Location = new System.Drawing.Point(50, 464);
            this.nudCountOfPeople.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCountOfPeople.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCountOfPeople.Name = "nudCountOfPeople";
            this.nudCountOfPeople.Size = new System.Drawing.Size(146, 27);
            this.nudCountOfPeople.TabIndex = 7;
            this.nudCountOfPeople.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(351, 210);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(151, 27);
            this.tbCountry.TabIndex = 8;
            this.tbCountry.Visible = false;
            // 
            // usSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.nudCountOfPeople);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addNewClientsWithSales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNameOfRoute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usSales";
            this.Size = new System.Drawing.Size(997, 886);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbNameOfRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewClientsWithSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCountOfPeople;
        private System.Windows.Forms.TextBox tbCountry;
    }
}
