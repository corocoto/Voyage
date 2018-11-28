namespace Voyage
{
    partial class usGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usGroups));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderTop = new System.Windows.Forms.Panel();
            this.borderRight = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.excelBtn = new System.Windows.Forms.Button();
            this.workWithClientsBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.createNewGroupBtn = new System.Windows.Forms.Button();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // borderLeft
            // 
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(7, 886);
            this.borderLeft.TabIndex = 0;
            // 
            // borderTop
            // 
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(7, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(990, 7);
            this.borderTop.TabIndex = 0;
            // 
            // borderRight
            // 
            this.borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight.Location = new System.Drawing.Point(990, 7);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(7, 872);
            this.borderRight.TabIndex = 0;
            // 
            // borderBottom
            // 
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(7, 879);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(990, 7);
            this.borderBottom.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Blue;
            this.headerPanel.Controls.Add(this.deleteBtn);
            this.headerPanel.Controls.Add(this.excelBtn);
            this.headerPanel.Controls.Add(this.workWithClientsBtn);
            this.headerPanel.Controls.Add(this.editBtn);
            this.headerPanel.Controls.Add(this.createNewGroupBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(7, 7);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(983, 89);
            this.headerPanel.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(823, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 89);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "     Удалить";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // excelBtn
            // 
            this.excelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excelBtn.FlatAppearance.BorderSize = 0;
            this.excelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelBtn.Image = ((System.Drawing.Image)(resources.GetObject("excelBtn.Image")));
            this.excelBtn.Location = new System.Drawing.Point(654, 0);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(163, 89);
            this.excelBtn.TabIndex = 3;
            this.excelBtn.Text = "     Вывод";
            this.excelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excelBtn.UseVisualStyleBackColor = true;
            // 
            // workWithClientsBtn
            // 
            this.workWithClientsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workWithClientsBtn.FlatAppearance.BorderSize = 0;
            this.workWithClientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workWithClientsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workWithClientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("workWithClientsBtn.Image")));
            this.workWithClientsBtn.Location = new System.Drawing.Point(394, 0);
            this.workWithClientsBtn.Name = "workWithClientsBtn";
            this.workWithClientsBtn.Size = new System.Drawing.Size(260, 89);
            this.workWithClientsBtn.TabIndex = 2;
            this.workWithClientsBtn.Text = "     Работа с клиентами";
            this.workWithClientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workWithClientsBtn.UseVisualStyleBackColor = true;
            this.workWithClientsBtn.Click += new System.EventHandler(this.workWithClientsBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(225, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(169, 89);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "     Изменить";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // createNewGroupBtn
            // 
            this.createNewGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createNewGroupBtn.FlatAppearance.BorderSize = 0;
            this.createNewGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewGroupBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewGroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("createNewGroupBtn.Image")));
            this.createNewGroupBtn.Location = new System.Drawing.Point(0, 0);
            this.createNewGroupBtn.Name = "createNewGroupBtn";
            this.createNewGroupBtn.Size = new System.Drawing.Size(225, 89);
            this.createNewGroupBtn.TabIndex = 0;
            this.createNewGroupBtn.Text = "     Добавить новую группу";
            this.createNewGroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createNewGroupBtn.UseVisualStyleBackColor = true;
            this.createNewGroupBtn.Click += new System.EventHandler(this.createNewGroupBtn_Click);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(7, 96);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGroups.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(983, 783);
            this.dgvGroups.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(354, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 181);
            this.label1.TabIndex = 4;
            this.label1.Text = "свойство \"Количество туристов в группе\" + кнопка \"добавить туристов\" + вывод спис" +
    "ка туристов в группе в отдельном окне + возможность редактирования данного списк" +
    "а";
            // 
            // usGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.borderLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usGroups";
            this.Size = new System.Drawing.Size(997, 886);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borderLeft;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.Panel borderRight;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button createNewGroupBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button workWithClientsBtn;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Label label1;
    }
}
