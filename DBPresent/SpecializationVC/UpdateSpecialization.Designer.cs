namespace DBPresent.SpecializationVC
{
    partial class UpdateSpecialization
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
            this.NameVCLabel = new System.Windows.Forms.Label();
            this.NameSpecLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.IdSpecNameLabel = new System.Windows.Forms.Label();
            this.IdSpecLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameVCLabel
            // 
            this.NameVCLabel.AutoSize = true;
            this.NameVCLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NameVCLabel.Location = new System.Drawing.Point(168, 9);
            this.NameVCLabel.Name = "NameVCLabel";
            this.NameVCLabel.Size = new System.Drawing.Size(109, 45);
            this.NameVCLabel.TabIndex = 0;
            this.NameVCLabel.Text = "label1";
            // 
            // NameSpecLabel
            // 
            this.NameSpecLabel.AutoSize = true;
            this.NameSpecLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameSpecLabel.Location = new System.Drawing.Point(27, 90);
            this.NameSpecLabel.Name = "NameSpecLabel";
            this.NameSpecLabel.Size = new System.Drawing.Size(91, 38);
            this.NameSpecLabel.TabIndex = 1;
            this.NameSpecLabel.Text = "label2";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTB.Location = new System.Drawing.Point(27, 150);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(218, 43);
            this.NameTB.TabIndex = 2;
            // 
            // IdSpecNameLabel
            // 
            this.IdSpecNameLabel.AutoSize = true;
            this.IdSpecNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecNameLabel.Location = new System.Drawing.Point(336, 90);
            this.IdSpecNameLabel.Name = "IdSpecNameLabel";
            this.IdSpecNameLabel.Size = new System.Drawing.Size(91, 38);
            this.IdSpecNameLabel.TabIndex = 3;
            this.IdSpecNameLabel.Text = "label3";
            // 
            // IdSpecLabel
            // 
            this.IdSpecLabel.AutoSize = true;
            this.IdSpecLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecLabel.Location = new System.Drawing.Point(336, 155);
            this.IdSpecLabel.Name = "IdSpecLabel";
            this.IdSpecLabel.Size = new System.Drawing.Size(91, 38);
            this.IdSpecLabel.TabIndex = 4;
            this.IdSpecLabel.Text = "label4";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(168, 241);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(182, 65);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "button1";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 333);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.IdSpecLabel);
            this.Controls.Add(this.IdSpecNameLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameSpecLabel);
            this.Controls.Add(this.NameVCLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateSpecialization";
            this.Text = "UpdateSpecialization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateSpecialization_FormClosing);
            this.Load += new System.EventHandler(this.UpdateSpecialization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameVCLabel;
        private Label NameSpecLabel;
        private TextBox NameTB;
        private Label IdSpecNameLabel;
        private Label IdSpecLabel;
        private Button ChangeButton;
    }
}