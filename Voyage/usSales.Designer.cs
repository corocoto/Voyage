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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(552, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbNameOfRoute
            // 
            this.cbNameOfRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNameOfRoute.FormattingEnabled = true;
            this.cbNameOfRoute.Location = new System.Drawing.Point(81, 276);
            this.cbNameOfRoute.Name = "cbNameOfRoute";
            this.cbNameOfRoute.Size = new System.Drawing.Size(275, 29);
            this.cbNameOfRoute.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название маршрута";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 371);
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
            this.addNewClientsWithSales.Location = new System.Drawing.Point(81, 545);
            this.addNewClientsWithSales.Name = "addNewClientsWithSales";
            this.addNewClientsWithSales.Size = new System.Drawing.Size(275, 77);
            this.addNewClientsWithSales.TabIndex = 5;
            this.addNewClientsWithSales.Text = "     Оформит заказ";
            this.addNewClientsWithSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewClientsWithSales.UseVisualStyleBackColor = true;
            // 
            // usSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addNewClientsWithSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNameOfRoute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usSales";
            this.Size = new System.Drawing.Size(997, 886);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}
