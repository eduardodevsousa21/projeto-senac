namespace Login
{
    partial class Rastreamento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAdicionar = new Button();
            btnEditar = new Button();
            button5 = new Button();
            dgvRastreamento = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtProduto = new TextBox();
            txtOrigem = new TextBox();
            txtData = new TextBox();
            txtLocalidade = new TextBox();
            txtPrevisao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRastreamento).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Tahoma", 14F, FontStyle.Bold | FontStyle.Underline);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(692, 583);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(153, 56);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 14F, FontStyle.Bold | FontStyle.Underline);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(879, 583);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 56);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 14F, FontStyle.Bold | FontStyle.Underline);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1065, 583);
            button5.Name = "button5";
            button5.Size = new Size(153, 56);
            button5.TabIndex = 6;
            button5.Text = "Deletar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgvRastreamento
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRastreamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRastreamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRastreamento.ColumnHeadersVisible = false;
            dgvRastreamento.Location = new Point(0, -1);
            dgvRastreamento.MultiSelect = false;
            dgvRastreamento.Name = "dgvRastreamento";
            dgvRastreamento.ReadOnly = true;
            dgvRastreamento.RowHeadersVisible = false;
            dgvRastreamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRastreamento.Size = new Size(637, 640);
            dgvRastreamento.TabIndex = 7;
            dgvRastreamento.SelectionChanged += dgvRastreamento_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(770, 103);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 8;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(770, 158);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 9;
            label2.Text = "PRODUTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(770, 219);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 10;
            label3.Text = "ORIGEM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(770, 283);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 11;
            label4.Text = "DATA DE SAIDA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(770, 356);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 12;
            label5.Text = "LOCALIDADE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(770, 425);
            label6.Name = "label6";
            label6.Size = new Size(219, 25);
            label6.TabIndex = 13;
            label6.Text = "PREVISÃO DE CHEGADA:";
            // 
            // txtId
            // 
            txtId.Location = new Point(770, 131);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 14;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(771, 186);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(293, 23);
            txtProduto.TabIndex = 15;
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new Point(770, 247);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(294, 23);
            txtOrigem.TabIndex = 15;
            // 
            // txtData
            // 
            txtData.Location = new Point(771, 311);
            txtData.Name = "txtData";
            txtData.Size = new Size(293, 23);
            txtData.TabIndex = 15;
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(771, 384);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(293, 23);
            txtLocalidade.TabIndex = 15;
            // 
            // txtPrevisao
            // 
            txtPrevisao.Location = new Point(771, 453);
            txtPrevisao.Name = "txtPrevisao";
            txtPrevisao.Size = new Size(293, 23);
            txtPrevisao.TabIndex = 15;
            // 
            // Rastreamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1230, 638);
            Controls.Add(txtPrevisao);
            Controls.Add(txtLocalidade);
            Controls.Add(txtData);
            Controls.Add(txtOrigem);
            Controls.Add(txtProduto);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRastreamento);
            Controls.Add(button5);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Name = "Rastreamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rastreamento";
            Load += Rastreamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRastreamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private Button btnEditar;
        private Button button5;
        private DataGridView dgvRastreamento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtProduto;
        private TextBox txtOrigem;
        private TextBox txtData;
        private TextBox txtLocalidade;
        private TextBox txtPrevisao;
    }
}