namespace finanças_Projeto
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
            components = new System.ComponentModel.Container();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            BTXROI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1173, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 28F);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(464, 22);
            label1.Name = "label1";
            label1.Size = new Size(239, 53);
            label1.TabIndex = 1;
            label1.Text = "FINANCEIRO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(40, 212);
            button1.Name = "button1";
            button1.Size = new Size(302, 58);
            button1.TabIndex = 5;
            button1.Text = "FATURAS E COBRANÇAS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(816, 215);
            button2.Name = "button2";
            button2.Size = new Size(251, 55);
            button2.TabIndex = 6;
            button2.Text = "FLUXO DE CAIXA";
            button2.UseVisualStyleBackColor = true;
            // 
            // BTXROI
            // 
            BTXROI.Font = new Font("Segoe UI", 18F);
            BTXROI.Location = new Point(513, 440);
            BTXROI.Name = "BTXROI";
            BTXROI.Size = new Size(129, 46);
            BTXROI.TabIndex = 7;
            BTXROI.Text = "ROI";
            BTXROI.UseVisualStyleBackColor = true;
            BTXROI.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1171, 568);
            Controls.Add(BTXROI);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button BTXROI;
    }
}
