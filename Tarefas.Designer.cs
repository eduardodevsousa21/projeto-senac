namespace Login
{
    partial class Tarefas
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
            dgvTarefas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTarefas = new TextBox();
            mtxtPrazo = new MaskedTextBox();
            txtId = new TextBox();
            label3 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.EnableHeadersVisualStyles = false;
            dgvTarefas.Location = new Point(-2, -2);
            dgvTarefas.MultiSelect = false;
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersVisible = false;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.Size = new Size(508, 453);
            dgvTarefas.TabIndex = 1;
            dgvTarefas.SelectionChanged += dgvTarefas_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(603, 115);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 2;
            label1.Text = "Tarefas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(603, 178);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 3;
            label2.Text = "Prazo:";
            label2.Click += label2_Click;
            // 
            // txtTarefas
            // 
            txtTarefas.Location = new Point(603, 146);
            txtTarefas.Name = "txtTarefas";
            txtTarefas.Size = new Size(459, 23);
            txtTarefas.TabIndex = 4;
            // 
            // mtxtPrazo
            // 
            mtxtPrazo.Location = new Point(603, 209);
            mtxtPrazo.Mask = "00/00/0000";
            mtxtPrazo.Name = "mtxtPrazo";
            mtxtPrazo.Size = new Size(100, 23);
            mtxtPrazo.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(740, 209);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(740, 178);
            label3.Name = "label3";
            label3.Size = new Size(35, 28);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            label3.Click += label2_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(603, 257);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Silver;
            btnExcluir.FlatAppearance.BorderColor = Color.Black;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(740, 257);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(117, 40);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Tarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtId);
            Controls.Add(mtxtPrazo);
            Controls.Add(txtTarefas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTarefas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Tarefas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas";
            Load += Tarefas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTarefas;
        private Label label1;
        private Label label2;
        private TextBox txtTarefas;
        private MaskedTextBox mtxtPrazo;
        private TextBox txtId;
        private Label label3;
        private Button btnEditar;
        private Button btnExcluir;
    }
}