namespace RH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            lblCdF = new ToolStripMenuItem();
            cadastreOFuncionarioToolStripMenuItem = new ToolStripMenuItem();
            lblGSB = new ToolStripMenuItem();
            lblCPH = new ToolStripMenuItem();
            LbLADF = new ToolStripMenuItem();
            lblGL = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lblCdF, lblGSB, lblCPH, LbLADF, lblGL });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1157, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lblCdF
            // 
            lblCdF.DropDownItems.AddRange(new ToolStripItem[] { cadastreOFuncionarioToolStripMenuItem });
            lblCdF.Name = "lblCdF";
            lblCdF.Size = new Size(149, 20);
            lblCdF.Text = "Cadastro de funcionario ";
            lblCdF.Click += cadastroDeFuncionarioToolStripMenuItem_Click;
            // 
            // cadastreOFuncionarioToolStripMenuItem
            // 
            cadastreOFuncionarioToolStripMenuItem.Name = "cadastreOFuncionarioToolStripMenuItem";
            cadastreOFuncionarioToolStripMenuItem.Size = new Size(194, 22);
            cadastreOFuncionarioToolStripMenuItem.Text = "Cadastre o funcionario";
            // 
            // lblGSB
            // 
            lblGSB.Name = "lblGSB";
            lblGSB.Size = new Size(175, 20);
            lblGSB.Text = "Gestão de Salario e beneficios";
            // 
            // lblCPH
            // 
            lblCPH.Name = "lblCPH";
            lblCPH.Size = new Size(162, 20);
            lblCPH.Text = "Controle de pontos e horas";
            // 
            // LbLADF
            // 
            LbLADF.Name = "LbLADF";
            LbLADF.Size = new Size(243, 20);
            LbLADF.Text = "Avalição de desempenho dos funcionarios";
            // 
            // lblGL
            // 
            lblGL.Name = "lblGL";
            lblGL.Size = new Size(119, 20);
            lblGL.Text = "Gestão de Licenças";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1176, 579);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 650);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lblCdF;
        private ToolStripMenuItem lblGSB;
        private ToolStripMenuItem lblCPH;
        private ToolStripMenuItem LbLADF;
        private ToolStripMenuItem cadastreOFuncionarioToolStripMenuItem;
        private ToolStripMenuItem lblGL;
        private PictureBox pictureBox1;
    }
}
