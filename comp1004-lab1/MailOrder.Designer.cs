namespace comp1004_lab1
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
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.LehelGuitarsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LehelGuitarsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(147, 22);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(55, 13);
            this.LanguageLabel.TabIndex = 0;
            this.LanguageLabel.Text = "Language";
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(150, 42);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 1;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(150, 66);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 2;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Francais";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this._FrenchRadioButton_CheckedChanged);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(17, 119);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(94, 13);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Employee\'s Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(17, 146);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(16, 173);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            this.HoursWorkedLabel.TabIndex = 5;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(17, 200);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(63, 13);
            this.TotalSalesLabel.TabIndex = 6;
            this.TotalSalesLabel.Text = "Total Sales:";
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(17, 227);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(69, 13);
            this.SalesBonusLabel.TabIndex = 7;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(19, 268);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this._CalculateButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(110, 268);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this._PrintButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(197, 268);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this._ClearButton_Click);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(117, 116);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.EmployeeNameTextBox.TabIndex = 11;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(117, 143);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 12;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(117, 170);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 13;
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Location = new System.Drawing.Point(117, 197);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesTextBox.TabIndex = 14;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(117, 224);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 15;
            // 
            // LehelGuitarsPictureBox
            // 
            this.LehelGuitarsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LehelGuitarsPictureBox.Image")));
            this.LehelGuitarsPictureBox.Location = new System.Drawing.Point(19, 22);
            this.LehelGuitarsPictureBox.Name = "LehelGuitarsPictureBox";
            this.LehelGuitarsPictureBox.Size = new System.Drawing.Size(92, 77);
            this.LehelGuitarsPictureBox.TabIndex = 16;
            this.LehelGuitarsPictureBox.TabStop = false;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(292, 303);
            this.Controls.Add(this.LehelGuitarsPictureBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.FrenchRadioButton);
            this.Controls.Add(this.EnglishRadioButton);
            this.Controls.Add(this.LanguageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lehel Guitars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._LehelGuitarsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LehelGuitarsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.PictureBox LehelGuitarsPictureBox;
    }
}

