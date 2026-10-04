namespace SMU
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
            label1 = new Label();
            txbjautajums = new TextBox();
            button1 = new Button();
            pic1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 189);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Labdien!";
            // 
            // txbjautajums
            // 
            txbjautajums.Location = new Point(416, 494);
            txbjautajums.Name = "txbjautajums";
            txbjautajums.Size = new Size(682, 31);
            txbjautajums.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(529, 573);
            button1.Name = "button1";
            button1.Size = new Size(180, 157);
            button1.TabIndex = 2;
            button1.Text = "Jautāt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pic1
            // 
            pic1.Location = new Point(1104, 247);
            pic1.Name = "pic1";
            pic1.Size = new Size(457, 509);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 3;
            pic1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(1221, 807);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Augšuplādēt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1707, 1035);
            Controls.Add(button2);
            Controls.Add(pic1);
            Controls.Add(button1);
            Controls.Add(txbjautajums);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbjautajums;
        private Button button1;
        private PictureBox pic1;
        private Button button2;
    }
}
