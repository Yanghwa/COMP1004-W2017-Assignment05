namespace Assignment01
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.TotalHoursWorked = new System.Windows.Forms.Label();
            this.TotalMontlySales = new System.Windows.Forms.Label();
            this.SaleBonus = new System.Windows.Forms.Label();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.EmployeeIdText = new System.Windows.Forms.TextBox();
            this.TotalHoursWorkedText = new System.Windows.Forms.TextBox();
            this.TotalMontlySalesText = new System.Windows.Forms.TextBox();
            this.SalesBonusText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LanguageBox = new System.Windows.Forms.GroupBox();
            this.RadioKoreanButton = new System.Windows.Forms.RadioButton();
            this.RadioFrenchButton = new System.Windows.Forms.RadioButton();
            this.RadioEnglishButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.LanguageBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Assignment01.Properties.Resources.logo;
            this.LogoPicture.InitialImage = null;
            this.LogoPicture.Location = new System.Drawing.Point(18, 13);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(150, 150);
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeName.Location = new System.Drawing.Point(3, 9);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(186, 25);
            this.EmployeeName.TabIndex = 2;
            this.EmployeeName.Text = "Employee\'s Name : ";
            // 
            // EmployeeId
            // 
            this.EmployeeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeId.Location = new System.Drawing.Point(3, 53);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(134, 25);
            this.EmployeeId.TabIndex = 3;
            this.EmployeeId.Text = "Employee ID :";
            // 
            // TotalHoursWorked
            // 
            this.TotalHoursWorked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalHoursWorked.AutoSize = true;
            this.TotalHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalHoursWorked.Location = new System.Drawing.Point(3, 97);
            this.TotalHoursWorked.Name = "TotalHoursWorked";
            this.TotalHoursWorked.Size = new System.Drawing.Size(198, 25);
            this.TotalHoursWorked.TabIndex = 4;
            this.TotalHoursWorked.Text = "Total Hours Worked :";
            // 
            // TotalMontlySales
            // 
            this.TotalMontlySales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalMontlySales.AutoSize = true;
            this.TotalMontlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalMontlySales.Location = new System.Drawing.Point(3, 141);
            this.TotalMontlySales.Name = "TotalMontlySales";
            this.TotalMontlySales.Size = new System.Drawing.Size(196, 25);
            this.TotalMontlySales.TabIndex = 5;
            this.TotalMontlySales.Text = "Total Monthly Sales :";
            // 
            // SaleBonus
            // 
            this.SaleBonus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaleBonus.AutoSize = true;
            this.SaleBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaleBonus.Location = new System.Drawing.Point(3, 187);
            this.SaleBonus.Name = "SaleBonus";
            this.SaleBonus.Size = new System.Drawing.Size(134, 25);
            this.SaleBonus.TabIndex = 6;
            this.SaleBonus.Text = "Sales Bonus :";
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeNameText.Location = new System.Drawing.Point(218, 7);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(235, 30);
            this.EmployeeNameText.TabIndex = 1;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeIdText.Location = new System.Drawing.Point(262, 51);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(147, 30);
            this.EmployeeIdText.TabIndex = 2;
            // 
            // TotalHoursWorkedText
            // 
            this.TotalHoursWorkedText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalHoursWorkedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalHoursWorkedText.Location = new System.Drawing.Point(262, 95);
            this.TotalHoursWorkedText.MaxLength = 160;
            this.TotalHoursWorkedText.Name = "TotalHoursWorkedText";
            this.TotalHoursWorkedText.Size = new System.Drawing.Size(147, 30);
            this.TotalHoursWorkedText.TabIndex = 3;
            this.TotalHoursWorkedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._numberValuesValidation);
            // 
            // TotalMontlySalesText
            // 
            this.TotalMontlySalesText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalMontlySalesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalMontlySalesText.Location = new System.Drawing.Point(262, 139);
            this.TotalMontlySalesText.Name = "TotalMontlySalesText";
            this.TotalMontlySalesText.Size = new System.Drawing.Size(147, 30);
            this.TotalMontlySalesText.TabIndex = 4;
            this.TotalMontlySalesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._numberValuesValidation);
            // 
            // SalesBonusText
            // 
            this.SalesBonusText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesBonusText.BackColor = System.Drawing.Color.White;
            this.SalesBonusText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesBonusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SalesBonusText.Location = new System.Drawing.Point(262, 184);
            this.SalesBonusText.Name = "SalesBonusText";
            this.SalesBonusText.ReadOnly = true;
            this.SalesBonusText.Size = new System.Drawing.Size(147, 30);
            this.SalesBonusText.TabIndex = 11;
            this.SalesBonusText.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalculateButton.Location = new System.Drawing.Point(8, 395);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 37);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrintButton.Location = new System.Drawing.Point(173, 395);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(128, 37);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearButton.Location = new System.Drawing.Point(338, 395);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(128, 37);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Next";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LanguageBox
            // 
            this.LanguageBox.Controls.Add(this.RadioKoreanButton);
            this.LanguageBox.Controls.Add(this.RadioFrenchButton);
            this.LanguageBox.Controls.Add(this.RadioEnglishButton);
            this.LanguageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LanguageBox.Location = new System.Drawing.Point(184, 12);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(200, 136);
            this.LanguageBox.TabIndex = 12;
            this.LanguageBox.TabStop = false;
            this.LanguageBox.Text = "Languages";
            // 
            // RadioKoreanButton
            // 
            this.RadioKoreanButton.AutoSize = true;
            this.RadioKoreanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioKoreanButton.Location = new System.Drawing.Point(20, 102);
            this.RadioKoreanButton.Name = "RadioKoreanButton";
            this.RadioKoreanButton.Size = new System.Drawing.Size(82, 29);
            this.RadioKoreanButton.TabIndex = 7;
            this.RadioKoreanButton.TabStop = true;
            this.RadioKoreanButton.Text = "한국어";
            this.RadioKoreanButton.UseVisualStyleBackColor = true;
            this.RadioKoreanButton.CheckedChanged += new System.EventHandler(this._language_CheckedChanged);
            // 
            // RadioFrenchButton
            // 
            this.RadioFrenchButton.AutoSize = true;
            this.RadioFrenchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioFrenchButton.Location = new System.Drawing.Point(20, 68);
            this.RadioFrenchButton.Name = "RadioFrenchButton";
            this.RadioFrenchButton.Size = new System.Drawing.Size(112, 29);
            this.RadioFrenchButton.TabIndex = 6;
            this.RadioFrenchButton.TabStop = true;
            this.RadioFrenchButton.Text = "Français";
            this.RadioFrenchButton.UseVisualStyleBackColor = true;
            this.RadioFrenchButton.CheckedChanged += new System.EventHandler(this._language_CheckedChanged);
            // 
            // RadioEnglishButton
            // 
            this.RadioEnglishButton.AutoSize = true;
            this.RadioEnglishButton.Checked = true;
            this.RadioEnglishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioEnglishButton.Location = new System.Drawing.Point(20, 34);
            this.RadioEnglishButton.Name = "RadioEnglishButton";
            this.RadioEnglishButton.Size = new System.Drawing.Size(101, 29);
            this.RadioEnglishButton.TabIndex = 5;
            this.RadioEnglishButton.TabStop = true;
            this.RadioEnglishButton.Text = "English";
            this.RadioEnglishButton.UseVisualStyleBackColor = true;
            this.RadioEnglishButton.CheckedChanged += new System.EventHandler(this._language_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeNameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeIdText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalHoursWorked, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SalesBonusText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalHoursWorkedText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotalMontlySalesText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TotalMontlySales, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaleBonus, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 223);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // MailOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LanguageBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LogoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesBonus";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.LanguageBox.ResumeLayout(false);
            this.LanguageBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label TotalHoursWorked;
        private System.Windows.Forms.Label TotalMontlySales;
        private System.Windows.Forms.Label SaleBonus;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.TextBox EmployeeIdText;
        private System.Windows.Forms.TextBox TotalHoursWorkedText;
        private System.Windows.Forms.TextBox TotalMontlySalesText;
        private System.Windows.Forms.TextBox SalesBonusText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.RadioButton RadioKoreanButton;
        private System.Windows.Forms.RadioButton RadioFrenchButton;
        private System.Windows.Forms.RadioButton RadioEnglishButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

