namespace Voyage
{
    partial class workWithClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workWithClients));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delPunct = new System.Windows.Forms.Button();
            this.addPunct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lFreePlacesCount = new System.Windows.Forms.Label();
            this.cbClientsInThisGroup = new System.Windows.Forms.ComboBox();
            this.cbAllClients = new System.Windows.Forms.ComboBox();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 573);
            this.panel3.TabIndex = 168;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 10);
            this.panel4.TabIndex = 169;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 10);
            this.panel2.TabIndex = 170;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 593);
            this.panel1.TabIndex = 171;
            // 
            // delPunct
            // 
            this.delPunct.BackColor = System.Drawing.Color.Crimson;
            this.delPunct.FlatAppearance.BorderSize = 0;
            this.delPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.delPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPunct.ForeColor = System.Drawing.Color.White;
            this.delPunct.Location = new System.Drawing.Point(295, 359);
            this.delPunct.Name = "delPunct";
            this.delPunct.Size = new System.Drawing.Size(50, 42);
            this.delPunct.TabIndex = 212;
            this.delPunct.Text = "-";
            this.delPunct.UseVisualStyleBackColor = false;
            this.delPunct.Click += new System.EventHandler(this.delPunct_Click);
            // 
            // addPunct
            // 
            this.addPunct.BackColor = System.Drawing.Color.DodgerBlue;
            this.addPunct.FlatAppearance.BorderSize = 0;
            this.addPunct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.addPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPunct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPunct.ForeColor = System.Drawing.Color.White;
            this.addPunct.Location = new System.Drawing.Point(239, 359);
            this.addPunct.Name = "addPunct";
            this.addPunct.Size = new System.Drawing.Size(50, 42);
            this.addPunct.TabIndex = 213;
            this.addPunct.Text = "+";
            this.addPunct.UseVisualStyleBackColor = false;
            this.addPunct.Click += new System.EventHandler(this.addPunct_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(98, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 21);
            this.label6.TabIndex = 205;
            this.label6.Text = "Клиенты, которые находятся в списке этой группы";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(203, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 206;
            this.label3.Text = "Список всех клиентов";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(171, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 21);
            this.label5.TabIndex = 207;
            this.label5.Text = "Количество свободных мест:";
            // 
            // lFreePlacesCount
            // 
            this.lFreePlacesCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFreePlacesCount.AutoSize = true;
            this.lFreePlacesCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFreePlacesCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lFreePlacesCount.Location = new System.Drawing.Point(265, 517);
            this.lFreePlacesCount.Name = "lFreePlacesCount";
            this.lFreePlacesCount.Size = new System.Drawing.Size(34, 24);
            this.lFreePlacesCount.TabIndex = 208;
            this.lFreePlacesCount.Text = "15";
            // 
            // cbClientsInThisGroup
            // 
            this.cbClientsInThisGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClientsInThisGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsInThisGroup.FormattingEnabled = true;
            this.cbClientsInThisGroup.Location = new System.Drawing.Point(194, 287);
            this.cbClientsInThisGroup.Name = "cbClientsInThisGroup";
            this.cbClientsInThisGroup.Size = new System.Drawing.Size(201, 29);
            this.cbClientsInThisGroup.TabIndex = 209;
            // 
            // cbAllClients
            // 
            this.cbAllClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAllClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllClients.FormattingEnabled = true;
            this.cbAllClients.Location = new System.Drawing.Point(195, 175);
            this.cbAllClients.Name = "cbAllClients";
            this.cbAllClients.Size = new System.Drawing.Size(201, 29);
            this.cbAllClients.TabIndex = 210;
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.FlatAppearance.BorderSize = 0;
            this.shutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.shutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shutdownBtn.ForeColor = System.Drawing.Color.White;
            this.shutdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("shutdownBtn.Image")));
            this.shutdownBtn.Location = new System.Drawing.Point(465, 10);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(122, 76);
            this.shutdownBtn.TabIndex = 203;
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 202;
            this.label1.Text = "Работа с клиентами";
            // 
            // workWithClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 593);
            this.Controls.Add(this.delPunct);
            this.Controls.Add(this.addPunct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lFreePlacesCount);
            this.Controls.Add(this.cbClientsInThisGroup);
            this.Controls.Add(this.cbAllClients);
            this.Controls.Add(this.shutdownBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "workWithClients";
            this.Text = "workWithClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delPunct;
        private System.Windows.Forms.Button addPunct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lFreePlacesCount;
        private System.Windows.Forms.ComboBox cbClientsInThisGroup;
        private System.Windows.Forms.ComboBox cbAllClients;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.Label label1;
    }
}