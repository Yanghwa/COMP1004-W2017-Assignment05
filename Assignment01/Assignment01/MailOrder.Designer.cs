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
            this.HoursWorked = new System.Windows.Forms.Label();
            this.TotalSales = new System.Windows.Forms.Label();
            this.SaleBonus = new System.Windows.Forms.Label();
            this.EmployeeNameText = new System.Windows.Forms.TextBox();
            this.EmployeeIdText = new System.Windows.Forms.TextBox();
            this.HoursWorkedText = new System.Windows.Forms.TextBox();
            this.TotalSalesText = new System.Windows.Forms.TextBox();
            this.SalesBonusText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LanguageBox = new System.Windows.Forms.GroupBox();
            this.RadioKoreanButton = new System.Windows.Forms.RadioButton();
            this.RadioFrenchButton = new System.Windows.Forms.RadioButton();
            this.RadioEnglishButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.LanguageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.InitialImage = null;
            this.LogoPicture.Location = new System.Drawing.Point(13, 13);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(150, 150);
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeName.Location = new System.Drawing.Point(8, 173);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(170, 25);
            this.EmployeeName.TabIndex = 2;
            this.EmployeeName.Text = "Employee\'s Name";
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeId.Location = new System.Drawing.Point(44, 219);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(134, 25);
            this.EmployeeId.TabIndex = 3;
            this.EmployeeId.Text = "Employee ID :";
            // 
            // HoursWorked
            // 
            this.HoursWorked.AutoSize = true;
            this.HoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HoursWorked.Location = new System.Drawing.Point(29, 265);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(149, 25);
            this.HoursWorked.TabIndex = 4;
            this.HoursWorked.Text = "Hours Worked :";
            // 
            // TotalSales
            // 
            this.TotalSales.AutoSize = true;
            this.TotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalSales.Location = new System.Drawing.Point(56, 311);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(122, 25);
            this.TotalSales.TabIndex = 5;
            this.TotalSales.Text = "Total Sales :";
            // 
            // SaleBonus
            // 
            this.SaleBonus.AutoSize = true;
            this.SaleBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaleBonus.Location = new System.Drawing.Point(55, 357);
            this.SaleBonus.Name = "SaleBonus";
            this.SaleBonus.Size = new System.Drawing.Size(123, 25);
            this.SaleBonus.TabIndex = 6;
            this.SaleBonus.Text = "Sales Bonus";
            // 
            // EmployeeNameText
            // 
            this.EmployeeNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeNameText.Location = new System.Drawing.Point(184, 173);
            this.EmployeeNameText.Name = "EmployeeNameText";
            this.EmployeeNameText.Size = new System.Drawing.Size(245, 30);
            this.EmployeeNameText.TabIndex = 1;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmployeeIdText.Location = new System.Drawing.Point(184, 218);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(147, 30);
            this.EmployeeIdText.TabIndex = 2;
            // 
            // HoursWorkedText
            // 
            this.HoursWorkedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HoursWorkedText.Location = new System.Drawing.Point(184, 263);
            this.HoursWorkedText.Name = "HoursWorkedText";
            this.HoursWorkedText.Size = new System.Drawing.Size(147, 30);
            this.HoursWorkedText.TabIndex = 3;
            // 
            // TotalSalesText
            // 
            this.TotalSalesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalSalesText.Location = new System.Drawing.Point(184, 308);
            this.TotalSalesText.Name = "TotalSalesText";
            this.TotalSalesText.Size = new System.Drawing.Size(147, 30);
            this.TotalSalesText.TabIndex = 4;
            // 
            // SalesBonusText
            // 
            this.SalesBonusText.BackColor = System.Drawing.Color.White;
            this.SalesBonusText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesBonusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SalesBonusText.Location = new System.Drawing.Point(184, 353);
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
            // 
            // MailOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.LanguageBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusText);
            this.Controls.Add(this.TotalSalesText);
            this.Controls.Add(this.HoursWorkedText);
            this.Controls.Add(this.EmployeeIdText);
            this.Controls.Add(this.EmployeeNameText);
            this.Controls.Add(this.SaleBonus);
            this.Controls.Add(this.TotalSales);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.LogoPicture);
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesBonus";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.LanguageBox.ResumeLayout(false);
            this.LanguageBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label HoursWorked;
        private System.Windows.Forms.Label TotalSales;
        private System.Windows.Forms.Label SaleBonus;
        private System.Windows.Forms.TextBox EmployeeNameText;
        private System.Windows.Forms.TextBox EmployeeIdText;
        private System.Windows.Forms.TextBox HoursWorkedText;
        private System.Windows.Forms.TextBox TotalSalesText;
        private System.Windows.Forms.TextBox SalesBonusText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.RadioButton RadioKoreanButton;
        private System.Windows.Forms.RadioButton RadioFrenchButton;
        private System.Windows.Forms.RadioButton RadioEnglishButton;
    }
}

