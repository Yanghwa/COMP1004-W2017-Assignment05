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
            this.TotalWorkedHours = new System.Windows.Forms.Label();
            this.TotalMonthlySales = new System.Windows.Forms.Label();
            this.SalesBonus = new System.Windows.Forms.Label();
            this.EmployeeNameInput = new System.Windows.Forms.TextBox();
            this.EmployeeIdInput = new System.Windows.Forms.TextBox();
            this.TotalWorkedHoursInput = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesInput = new System.Windows.Forms.TextBox();
            this.SalesBonusInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
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
            // TotalWorkedHours
            // 
            this.TotalWorkedHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalWorkedHours.AutoSize = true;
            this.TotalWorkedHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalWorkedHours.Location = new System.Drawing.Point(3, 97);
            this.TotalWorkedHours.Name = "TotalWorkedHours";
            this.TotalWorkedHours.Size = new System.Drawing.Size(198, 25);
            this.TotalWorkedHours.TabIndex = 4;
            this.TotalWorkedHours.Text = "Total Hours Worked :";
            // 
            // TotalMonthlySales
            // 
            this.TotalMonthlySales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalMonthlySales.AutoSize = true;
            this.TotalMonthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalMonthlySales.Location = new System.Drawing.Point(3, 141);
            this.TotalMonthlySales.Name = "TotalMonthlySales";
            this.TotalMonthlySales.Size = new System.Drawing.Size(196, 25);
            this.TotalMonthlySales.TabIndex = 5;
            this.TotalMonthlySales.Text = "Total Monthly Sales :";
            // 
            // SalesBonus
            // 
            this.SalesBonus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalesBonus.AutoSize = true;
            this.SalesBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SalesBonus.Location = new System.Drawing.Point(3, 187);
            this.SalesBonus.Name = "SalesBonus";
            this.SalesBonus.Size = new System.Drawing.Size(134, 25);
            this.SalesBonus.TabIndex = 6;
            this.SalesBonus.Text = "Sales Bonus :";
            // 
            // EmployeeNameInput
            // 
            this.EmployeeNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeNameInput.Location = new System.Drawing.Point(218, 7);
            this.EmployeeNameInput.Name = "EmployeeNameInput";
            this.EmployeeNameInput.Size = new System.Drawing.Size(235, 30);
            this.EmployeeNameInput.TabIndex = 1;
            // 
            // EmployeeIdInput
            // 
            this.EmployeeIdInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeIdInput.Location = new System.Drawing.Point(262, 51);
            this.EmployeeIdInput.Name = "EmployeeIdInput";
            this.EmployeeIdInput.Size = new System.Drawing.Size(147, 30);
            this.EmployeeIdInput.TabIndex = 2;
            // 
            // TotalWorkedHoursInput
            // 
            this.TotalWorkedHoursInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalWorkedHoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalWorkedHoursInput.Location = new System.Drawing.Point(262, 95);
            this.TotalWorkedHoursInput.MaxLength = 160;
            this.TotalWorkedHoursInput.Name = "TotalWorkedHoursInput";
            this.TotalWorkedHoursInput.Size = new System.Drawing.Size(147, 30);
            this.TotalWorkedHoursInput.TabIndex = 3;
            this.TotalWorkedHoursInput.TextChanged += new System.EventHandler(this.IsTooHighTotalHoursWorked);
            this.TotalWorkedHoursInput.Enter += new System.EventHandler(this.EnterTotalWorkedHourTap);
            this.TotalWorkedHoursInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._validateOnlyNumber);
            this.TotalWorkedHoursInput.Leave += new System.EventHandler(this.LeaveTotalWorkedHourTap);
            // 
            // TotalMonthlySalesInput
            // 
            this.TotalMonthlySalesInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalMonthlySalesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalMonthlySalesInput.Location = new System.Drawing.Point(262, 139);
            this.TotalMonthlySalesInput.Name = "TotalMonthlySalesInput";
            this.TotalMonthlySalesInput.Size = new System.Drawing.Size(147, 30);
            this.TotalMonthlySalesInput.TabIndex = 4;
            this.TotalMonthlySalesInput.Enter += new System.EventHandler(this.EnterTotalMonthlySalesTap);
            this.TotalMonthlySalesInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._validateOnlyNumber);
            this.TotalMonthlySalesInput.Leave += new System.EventHandler(this.LeaveTotalMonthlySalesTap);
            // 
            // SalesBonusInput
            // 
            this.SalesBonusInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesBonusInput.BackColor = System.Drawing.Color.White;
            this.SalesBonusInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesBonusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SalesBonusInput.Location = new System.Drawing.Point(262, 184);
            this.SalesBonusInput.Name = "SalesBonusInput";
            this.SalesBonusInput.ReadOnly = true;
            this.SalesBonusInput.Size = new System.Drawing.Size(147, 30);
            this.SalesBonusInput.TabIndex = 11;
            this.SalesBonusInput.TabStop = false;
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
            this.CalculateButton.Click += new System.EventHandler(this.ClickCalculatePrintButton);
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrintButton.Location = new System.Drawing.Point(173, 395);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(128, 37);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Tag = "Print";
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.ClickCalculatePrintButton);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NextButton.Location = new System.Drawing.Point(338, 395);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(128, 37);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ClickNextButton);
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
            this.RadioKoreanButton.CheckedChanged += new System.EventHandler(this._changeLanguages);
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
            this.RadioFrenchButton.CheckedChanged += new System.EventHandler(this._changeLanguages);
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
            this.RadioEnglishButton.CheckedChanged += new System.EventHandler(this._changeLanguages);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeNameInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeIdInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalWorkedHours, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SalesBonusInput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalWorkedHoursInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotalMonthlySalesInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TotalMonthlySales, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SalesBonus, 0, 4);
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
            this.Controls.Add(this.NextButton);
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
        private System.Windows.Forms.Label TotalWorkedHours;
        private System.Windows.Forms.Label TotalMonthlySales;
        private System.Windows.Forms.Label SalesBonus;
        private System.Windows.Forms.TextBox EmployeeNameInput;
        private System.Windows.Forms.TextBox EmployeeIdInput;
        private System.Windows.Forms.TextBox TotalWorkedHoursInput;
        private System.Windows.Forms.TextBox TotalMonthlySalesInput;
        private System.Windows.Forms.TextBox SalesBonusInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.RadioButton RadioKoreanButton;
        private System.Windows.Forms.RadioButton RadioFrenchButton;
        private System.Windows.Forms.RadioButton RadioEnglishButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

