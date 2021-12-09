namespace DBPresent
{
    partial class Hospital
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectTypeObject = new System.Windows.Forms.ComboBox();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTypeObject
            // 
            this.SelectTypeObject.FormattingEnabled = true;
            this.SelectTypeObject.Location = new System.Drawing.Point(223, 100);
            this.SelectTypeObject.Name = "SelectTypeObject";
            this.SelectTypeObject.Size = new System.Drawing.Size(421, 28);
            this.SelectTypeObject.TabIndex = 5;
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SelectLabel.Location = new System.Drawing.Point(344, 29);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(80, 35);
            this.SelectLabel.TabIndex = 6;
            this.SelectLabel.Text = "label1";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(397, 171);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(94, 29);
            this.SelectButton.TabIndex = 7;
            this.SelectButton.Text = "button1";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 316);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.SelectTypeObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Hospital";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox SelectTypeObject;
        private Label SelectLabel;
        private Button SelectButton;
    }
}