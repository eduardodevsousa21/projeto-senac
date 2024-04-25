using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Producao : Form
    {
        public Producao()
        {
            InitializeComponent();
        }

        private void Producao_Load(object sender, EventArgs e)
        {
            dgvProducao.DataSource = _dbBanco.ObterTarefas();
            dgvProducao.Columns[0].Width = 25;
            dgvProducao.Columns[1].Width = 370;
        }

        private void dgvProducao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int passador = 0;
            Login page0 = new Login();
            page0.Show();
            passador = 1;
            if (passador == 1)
            {
                this.Hide();
            }

        }
    }
}
