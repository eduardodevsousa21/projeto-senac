namespace finanças_Projeto
{
    partial class roi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxInicial = new TextBox();
            tbxCustos = new TextBox();
            tbxRetorno = new TextBox();
            btnCalc = new Button();
            lblResul = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 76);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Investimneto Incial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 150);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Custos Operacionais ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 223);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Retorno Financeiro";
            // 
            // tbxInicial
            // 
            tbxInicial.Location = new Point(408, 73);
            tbxInicial.Name = "tbxInicial";
            tbxInicial.Size = new Size(100, 23);
            tbxInicial.TabIndex = 3;
            tbxInicial.TextChanged += tbxInicial_TextChanged;
            // 
            // tbxCustos
            // 
            tbxCustos.Location = new Point(408, 147);
            tbxCustos.Name = "tbxCustos";
            tbxCustos.Size = new Size(100, 23);
            tbxCustos.TabIndex = 4;
            // 
            // tbxRetorno
            // 
            tbxRetorno.Location = new Point(408, 215);
            tbxRetorno.Name = "tbxRetorno";
            tbxRetorno.Size = new Size(100, 23);
            tbxRetorno.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(420, 287);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calcule ";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Location = new Point(652, 225);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(0, 15);
            lblResul.TabIndex = 7;
            // 
            // roi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResul);
            Controls.Add(btnCalc);
            Controls.Add(tbxRetorno);
            Controls.Add(tbxCustos);
            Controls.Add(tbxInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "roi";
            Text = "roi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxInicial;
        private TextBox tbxCustos;
        private TextBox tbxRetorno;
        private Button btnCalc;
        private Label lblResul;
    }
}