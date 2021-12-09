namespace DBPresent.CertificateVC
{
    partial class AddCertificate
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DoctorIdLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.DoctorIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(34, 44);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 45);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "label1";
            // 
            // DoctorIdLabel
            // 
            this.DoctorIdLabel.AutoSize = true;
            this.DoctorIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DoctorIdLabel.Location = new System.Drawing.Point(241, 44);
            this.DoctorIdLabel.Name = "DoctorIdLabel";
            this.DoctorIdLabel.Size = new System.Drawing.Size(112, 45);
            this.DoctorIdLabel.TabIndex = 1;
            this.DoctorIdLabel.Text = "label2";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(444, 44);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(111, 45);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "label3";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(18, 123);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(125, 27);
            this.DescriptionTB.TabIndex = 3;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.Location = new System.Drawing.Point(413, 123);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(187, 27);
            this.DatePicker.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(155, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(271, 77);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "button1";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DoctorIdComboBox
            // 
            this.DoctorIdComboBox.FormattingEnabled = true;
            this.DoctorIdComboBox.Location = new System.Drawing.Point(215, 125);
            this.DoctorIdComboBox.Name = "DoctorIdComboBox";
            this.DoctorIdComboBox.Size = new System.Drawing.Size(151, 28);
            this.DoctorIdComboBox.TabIndex = 7;
            // 
            // AddCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 390);
            this.Controls.Add(this.DoctorIdComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DoctorIdLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCertificate";
            this.Text = "AddCertificate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCertificate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DescriptionLabel;
        private Label DoctorIdLabel;
        private Label DateLabel;
        private TextBox DescriptionTB;
        private TextBox DoctorIdTB;
        private DateTimePicker DatePicker;
        private Button AddButton;
        private ComboBox DoctorIdComboBox;
    }
}