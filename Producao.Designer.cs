namespace Login
{
    partial class Producao
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProducao = new DataGridView();
            label1 = new Label();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducao).BeginInit();
            SuspendLayout();
            // 
            // dgvProducao
            // 
            dgvProducao.AllowUserToAddRows = false;
            dgvProducao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducao.EnableHeadersVisualStyles = false;
            dgvProducao.Location = new Point(-4, 30);
            dgvProducao.MultiSelect = false;
            dgvProducao.Name = "dgvProducao";
            dgvProducao.RowHeadersVisible = false;
            dgvProducao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducao.Size = new Size(508, 491);
            dgvProducao.TabIndex = 0;
            dgvProducao.CellContentClick += dgvProducao_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(67, -1);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 3;
            label1.Text = "Suas Tarefas do Dia:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGray;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(387, 521);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 31);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Voltar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // Producao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 553);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(dgvProducao);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Producao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producao";
            Load += Producao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducao;
        private Label label1;
        private Button btnEditar;
    }
}