namespace linlab_lisbox
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
            linkLabel1 = new LinkLabel();
            LkCalc = new LinkLabel();
            label1 = new Label();
            lxcursos = new ListBox();
            btnadd = new Button();
            btnremo = new Button();
            btnobt = new Button();
            tbxcursos = new TextBox();
            imageList1 = new ImageList(components);
            process1 = new System.Diagnostics.Process();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(620, 392);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(38, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Goole";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LkCalc
            // 
            LkCalc.AutoSize = true;
            LkCalc.Location = new Point(703, 392);
            LkCalc.Name = "LkCalc";
            LkCalc.Size = new Size(70, 15);
            LkCalc.TabIndex = 1;
            LkCalc.TabStop = true;
            LkCalc.Text = "Calculadora";
            LkCalc.LinkClicked += LkCalc_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 343);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Links Uteis ";
            // 
            // lxcursos
            // 
            lxcursos.FormattingEnabled = true;
            lxcursos.ItemHeight = 15;
            lxcursos.Location = new Point(110, 68);
            lxcursos.Name = "lxcursos";
            lxcursos.Size = new Size(120, 184);
            lxcursos.TabIndex = 3;
            lxcursos.SelectedIndexChanged += lxcursos_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(236, 138);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 5;
            btnadd.Text = "Adicionar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnremo
            // 
            btnremo.Location = new Point(317, 138);
            btnremo.Name = "btnremo";
            btnremo.Size = new Size(75, 23);
            btnremo.TabIndex = 6;
            btnremo.Text = "Remover";
            btnremo.UseVisualStyleBackColor = true;
            btnremo.Click += btnremo_Click;
            // 
            // btnobt
            // 
            btnobt.Location = new Point(398, 138);
            btnobt.Name = "btnobt";
            btnobt.Size = new Size(75, 23);
            btnobt.TabIndex = 7;
            btnobt.Text = "Obter";
            btnobt.UseVisualStyleBackColor = true;
            btnobt.Click += btnobt_Click;
            // 
            // tbxcursos
            // 
            tbxcursos.Location = new Point(306, 83);
            tbxcursos.Name = "tbxcursos";
            tbxcursos.Size = new Size(100, 23);
            tbxcursos.TabIndex = 8;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(276, 374);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(radioButton1);
            Controls.Add(tbxcursos);
            Controls.Add(btnobt);
            Controls.Add(btnremo);
            Controls.Add(btnadd);
            Controls.Add(lxcursos);
            Controls.Add(label1);
            Controls.Add(LkCalc);
            Controls.Add(linkLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel LkCalc;
        private Label label1;
        private ListBox lxcursos;
        private Button btnadd;
        private Button btnremo;
        private Button btnobt;
        private TextBox tbxcursos;
        private ImageList imageList1;
        private System.Diagnostics.Process process1;
        private RadioButton radioButton1;
    }
}
