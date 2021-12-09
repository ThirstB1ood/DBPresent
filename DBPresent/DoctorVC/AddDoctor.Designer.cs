namespace DBPresent.DoctorVC
{
    partial class AddDoctor
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdSpecLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.IdSpecComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(54, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 38);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label2";
            // 
            // IdSpecLabel
            // 
            this.IdSpecLabel.AutoSize = true;
            this.IdSpecLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecLabel.Location = new System.Drawing.Point(269, 45);
            this.IdSpecLabel.Name = "IdSpecLabel";
            this.IdSpecLabel.Size = new System.Drawing.Size(91, 38);
            this.IdSpecLabel.TabIndex = 2;
            this.IdSpecLabel.Text = "label3";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTB.Location = new System.Drawing.Point(35, 129);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(125, 43);
            this.NameTB.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(121, 224);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(166, 52);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "button1";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IdSpecComboBox
            // 
            this.IdSpecComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSpecComboBox.FormattingEnabled = true;
            this.IdSpecComboBox.Location = new System.Drawing.Point(244, 136);
            this.IdSpecComboBox.Name = "IdSpecComboBox";
            this.IdSpecComboBox.Size = new System.Drawing.Size(151, 36);
            this.IdSpecComboBox.TabIndex = 6;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 314);
            this.Controls.Add(this.IdSpecComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdSpecLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDoctor";
            this.Text = "AddDoctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDoctor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label NameLabel;
        private Label IdSpecLabel;
        private TextBox NameTB;
        private Button AddButton;
        private ComboBox IdSpecComboBox;
    }
}