namespace DBPresent.CertificateVC
{
    partial class UpdateCertificate
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DoctorIdLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DoctorIdComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(30, 45);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(120, 50);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "label1";
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTB.Location = new System.Drawing.Point(30, 144);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(109, 47);
            this.IdTB.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(206, 45);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(120, 50);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "label1";
            // 
            // DoctorIdLabel
            // 
            this.DoctorIdLabel.AutoSize = true;
            this.DoctorIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DoctorIdLabel.Location = new System.Drawing.Point(392, 45);
            this.DoctorIdLabel.Name = "DoctorIdLabel";
            this.DoctorIdLabel.Size = new System.Drawing.Size(120, 50);
            this.DoctorIdLabel.TabIndex = 3;
            this.DoctorIdLabel.Text = "label1";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(582, 45);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(120, 50);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "label1";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTB.Location = new System.Drawing.Point(168, 144);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(177, 47);
            this.DescriptionTB.TabIndex = 5;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.Location = new System.Drawing.Point(556, 159);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(190, 27);
            this.DatePicker.TabIndex = 6;
            // 
            // DoctorIdComboBox
            // 
            this.DoctorIdComboBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorIdComboBox.FormattingEnabled = true;
            this.DoctorIdComboBox.Location = new System.Drawing.Point(377, 144);
            this.DoctorIdComboBox.Name = "DoctorIdComboBox";
            this.DoctorIdComboBox.Size = new System.Drawing.Size(151, 49);
            this.DoctorIdComboBox.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(206, 277);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(315, 95);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "button1";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DoctorIdComboBox);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DoctorIdLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.IdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateCertificate";
            this.Text = "UpdateCertificate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateCertificate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IdLabel;
        private TextBox IdTB;
        private Label DescriptionLabel;
        private Label DoctorIdLabel;
        private Label DateLabel;
        private TextBox DescriptionTB;
        private DateTimePicker DatePicker;
        private ComboBox DoctorIdComboBox;
        private Button UpdateButton;
    }
}