namespace PrimeNumber
{
    partial class PrimeNumberForm
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
            this.CHECKButton = new System.Windows.Forms.Button();
            this.PrimeNumberTextBox = new System.Windows.Forms.TextBox();
            this.TrueOrFalseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CHECKButton
            // 
            this.CHECKButton.Location = new System.Drawing.Point(461, 311);
            this.CHECKButton.Name = "CHECKButton";
            this.CHECKButton.Size = new System.Drawing.Size(136, 58);
            this.CHECKButton.TabIndex = 0;
            this.CHECKButton.Text = "CHECK";
            this.CHECKButton.UseVisualStyleBackColor = true;
            this.CHECKButton.Click += new System.EventHandler(this.CHECKButton_Click);
            // 
            // PrimeNumberTextBox
            // 
            this.PrimeNumberTextBox.Location = new System.Drawing.Point(461, 223);
            this.PrimeNumberTextBox.Name = "PrimeNumberTextBox";
            this.PrimeNumberTextBox.Size = new System.Drawing.Size(136, 22);
            this.PrimeNumberTextBox.TabIndex = 1;
            // 
            // TrueOrFalseLabel
            // 
            this.TrueOrFalseLabel.AutoSize = true;
            this.TrueOrFalseLabel.Location = new System.Drawing.Point(343, 254);
            this.TrueOrFalseLabel.Name = "TrueOrFalseLabel";
            this.TrueOrFalseLabel.Size = new System.Drawing.Size(83, 16);
            this.TrueOrFalseLabel.TabIndex = 2;
            this.TrueOrFalseLabel.Text = "TrueOrFalse";
            // 
            // PrimeNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 567);
            this.Controls.Add(this.TrueOrFalseLabel);
            this.Controls.Add(this.PrimeNumberTextBox);
            this.Controls.Add(this.CHECKButton);
            this.Name = "PrimeNumberForm";
            this.Text = "PrimeNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CHECKButton;
        private System.Windows.Forms.TextBox PrimeNumberTextBox;
        private System.Windows.Forms.Label TrueOrFalseLabel;
    }
}

