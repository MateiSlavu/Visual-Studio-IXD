namespace MathQuiz
{
    partial class Form1
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
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            vv = new Label();
            sum = new NumericUpDown();
            timesRightTabel = new Label();
            minusRightLabel = new Label();
            dividedLeftLabel = new Label();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            dividedRightTabel = new Label();
            label10 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            quotient = new NumericUpDown();
            product = new NumericUpDown();
            difference = new NumericUpDown();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(270, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(127, 2);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.AutoSize = true;
            plusLeftLabel.Font = new Font("Segoe UI", 24F);
            plusLeftLabel.Location = new Point(51, 55);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(41, 54);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusLeftLabel.Click += label2_Click;
            // 
            // plusRightLabel
            // 
            plusRightLabel.AutoSize = true;
            plusRightLabel.Font = new Font("Segoe UI", 24F);
            plusRightLabel.Location = new Point(193, 55);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(41, 54);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(120, 61);
            label3.Name = "label3";
            label3.Size = new Size(39, 41);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vv
            // 
            vv.AutoSize = true;
            vv.Font = new Font("Segoe UI", 18F);
            vv.Location = new Point(270, 223);
            vv.Name = "vv";
            vv.Size = new Size(39, 41);
            vv.TabIndex = 5;
            vv.Text = "=";
            vv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(315, 55);
            sum.Name = "sum";
            sum.Size = new Size(100, 47);
            sum.TabIndex = 1;
            // 
            // timesRightTabel
            // 
            timesRightTabel.AutoSize = true;
            timesRightTabel.Font = new Font("Segoe UI", 24F);
            timesRightTabel.Location = new Point(193, 163);
            timesRightTabel.Name = "timesRightTabel";
            timesRightTabel.Size = new Size(41, 54);
            timesRightTabel.TabIndex = 7;
            timesRightTabel.Text = "?";
            timesRightTabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.AutoSize = true;
            minusRightLabel.Font = new Font("Segoe UI", 24F);
            minusRightLabel.Location = new Point(193, 109);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(41, 54);
            minusRightLabel.TabIndex = 8;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.AutoSize = true;
            dividedLeftLabel.Font = new Font("Segoe UI", 24F);
            dividedLeftLabel.Location = new Point(51, 217);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(41, 54);
            dividedLeftLabel.TabIndex = 9;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.AutoSize = true;
            minusLeftLabel.Font = new Font("Segoe UI", 24F);
            minusLeftLabel.Location = new Point(51, 109);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(41, 54);
            minusLeftLabel.TabIndex = 10;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.AutoSize = true;
            timesLeftLabel.Font = new Font("Segoe UI", 24F);
            timesLeftLabel.Location = new Point(51, 163);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(41, 54);
            timesLeftLabel.TabIndex = 11;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightTabel
            // 
            dividedRightTabel.AutoSize = true;
            dividedRightTabel.Font = new Font("Segoe UI", 24F);
            dividedRightTabel.Location = new Point(193, 217);
            dividedRightTabel.Name = "dividedRightTabel";
            dividedRightTabel.Size = new Size(41, 54);
            dividedRightTabel.TabIndex = 12;
            dividedRightTabel.Text = "?";
            dividedRightTabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(270, 115);
            label10.Name = "label10";
            label10.Size = new Size(39, 41);
            label10.TabIndex = 13;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(270, 167);
            label4.Name = "label4";
            label4.Size = new Size(39, 41);
            label4.TabIndex = 14;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(270, 61);
            label11.Name = "label11";
            label11.Size = new Size(39, 41);
            label11.TabIndex = 15;
            label11.Text = "=";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(122, 173);
            label12.Name = "label12";
            label12.Size = new Size(32, 41);
            label12.TabIndex = 16;
            label12.Text = "x";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(120, 227);
            label13.Name = "label13";
            label13.Size = new Size(39, 41);
            label13.TabIndex = 17;
            label13.Text = "÷";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(122, 119);
            label14.Name = "label14";
            label14.Size = new Size(30, 41);
            label14.TabIndex = 18;
            label14.Text = "-";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(315, 221);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 47);
            quotient.TabIndex = 4;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(315, 167);
            product.Name = "product";
            product.Size = new Size(100, 47);
            product.TabIndex = 3;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(315, 113);
            difference.Name = "difference";
            difference.Size = new Size(100, 47);
            difference.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(143, 290);
            startButton.Name = "startButton";
            startButton.Size = new Size(166, 42);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(startButton);
            Controls.Add(difference);
            Controls.Add(product);
            Controls.Add(quotient);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(dividedRightTabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(timesRightTabel);
            Controls.Add(sum);
            Controls.Add(vv);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label vv;
        private NumericUpDown sum;
        private Label timesRightTabel;
        private Label minusRightLabel;
        private Label dividedLeftLabel;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label dividedRightTabel;
        private Label label10;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private NumericUpDown quotient;
        private NumericUpDown product;
        private NumericUpDown difference;
        private Button startButton;
    }
}
