namespace DBPresent.DoctorVC
{
    partial class UpdateDoctor
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
            this.UpdateVCLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdSpecLabel = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.IdSpecComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpdateVCLabel
            // 
            this.UpdateVCLabel.AutoSize = true;
            this.UpdateVCLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UpdateVCLabel.Location = new System.Drawing.Point(173, 48);
            this.UpdateVCLabel.Name = "UpdateVCLabel";
            this.UpdateVCLabel.Size = new System.Drawing.Size(120, 50);
            this.UpdateVCLabel.TabIndex = 0;
            this.UpdateVCLabel.Text = "label1";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(60, 132);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(91, 38);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(273, 132);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 38);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label2";
            // 
            // IdSpecLabel
            // 
            this.IdSpecLabel.AutoSize = true;
            this.IdSpecLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecLabel.Location = new System.Drawing.Point(427, 132);
            this.IdSpecLabel.Name = "IdSpecLabel";
            this.IdSpecLabel.Size = new System.Drawing.Size(91, 38);
            this.IdSpecLabel.TabIndex = 3;
            this.IdSpecLabel.Text = "label3";
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTB.Location = new System.Drawing.Point(42, 212);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(125, 47);
            this.IdTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTB.Location = new System.Drawing.Point(256, 212);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(125, 47);
            this.NameTB.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(173, 294);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(272, 72);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "button1";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // IdSpecComboBox
            // 
            this.IdSpecComboBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecComboBox.FormattingEnabled = true;
            this.IdSpecComboBox.Location = new System.Drawing.Point(442, 212);
            this.IdSpecComboBox.Name = "IdSpecComboBox";
            this.IdSpecComboBox.Size = new System.Drawing.Size(216, 49);
            this.IdSpecComboBox.TabIndex = 8;
            // 
            // UpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 407);
            this.Controls.Add(this.IdSpecComboBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.IdSpecLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.UpdateVCLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateDoctor";
            this.Text = "UpdateDoctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateDoctor_FormClosing);
            this.Load += new System.EventHandler(this.UpdateDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UpdateVCLabel;
        private Label IdLabel;
        private Label NameLabel;
        private Label IdSpecLabel;
        private TextBox IdTB;
        private TextBox NameTB;
        private Button UpdateButton;
        private ComboBox IdSpecComboBox;
    }
}