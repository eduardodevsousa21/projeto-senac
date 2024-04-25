using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Tarefas : Form
    {
        public class tarefas
        {
            public int id;
            public string tarefa;
        }
        public Tarefas()
        {
            InitializeComponent();
        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            dgvTarefas.DataSource = _dbBanco.ObterTarefas();
            dgvTarefas.Columns[0].Width = 25;
            dgvTarefas.Columns[1].Width = 370;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbBanco.DeletarTarefas(txtId.Text);
                dgvTarefas.Rows.Remove(dgvTarefas.CurrentRow);
            }
        }

        private void dgvTarefas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgvTarefas.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["id"].Value);
                dt = _dbBanco.ObterTodasTarefas(vid);
                txtId.Text = dt.Rows[0].Field<Int64>("id").ToString();
                txtTarefas.Text = dt.Rows[0].Field<String>("tarefas").ToString();
                mtxtPrazo.Text = dt.Rows[0].Field<Int64>("prazo").ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvTarefas.SelectedRows[0].Index;
            _dbBanco.tarefas t = new _dbBanco.tarefas();
            t.id = Convert.ToInt32(txtId.Text);
            t.tarefa = Convert.ToString(txtTarefas.Text);

            // Corrigir a conversão da data
            DateTime prazo;
            if (DateTime.TryParseExact(mtxtPrazo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out prazo))
            {
                t.prazo = prazo;
            }
            else
            {
                // A entrada da data não está no formato esperado
                MessageBox.Show("A data inserida não está no formato correto (dd/MM/yyyy). Por favor, insira uma data válida.");
                return; // Interrompe o processo de atualização se a data não estiver no formato correto
            }

            _dbBanco.AtualizarTarefas(t);
            dgvTarefas.DataSource = _dbBanco.ObterTodasTarefas(t.id);
            dgvTarefas.CurrentCell = dgvTarefas[0, linha];
        }


        /*private void SeuMetodoDeSalvar()
        {
            string dataString = mtxtPrazo.Text; // Obtém a data do MaskedTextBox
            DateTime data;
            if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                // A conversão foi bem-sucedida, 'data' agora contém a data no formato desejado
                // Você pode usar 'data' para salvar no banco de dados ou fazer qualquer outra operação necessária
                // Exemplo: _dbBanco.SalvarData(data);
            }
            else
            {
                // A entrada da data não está no formato esperado
                MessageBox.Show("A data inserida não está no formato correto (dd/MM/yyyy). Por favor, insira uma data válida.");
                // Você pode exibir uma mensagem de erro ao usuário ou realizar outra ação apropriada
            }
        }*/

    }
}
