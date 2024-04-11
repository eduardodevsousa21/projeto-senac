using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finanças_Projeto
{
    public partial class roi : Form
    {
        public roi()
        {
            InitializeComponent();
        }

        private void tbxInicial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal retorno = Convert.ToDecimal(tbxRetorno.Text);
            decimal custos = Convert.ToDecimal(tbxCustos.Text);
            decimal inicial = Convert.ToDecimal(tbxInicial.Text);

            // Calculando o ROI
            decimal roi = ((retorno - custos) / inicial) * 100;
            roi = Math.Round(roi, 2);

            // Exibindo o resultado no rótulo
            lblResul.Text = $"ROI: {roi, 2}%";

        }
    }
}
