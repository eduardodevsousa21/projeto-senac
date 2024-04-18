using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolaPe_RH
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario = tbxUsuario.Text;
            usuario.senha = tbxSenha.Text;
            usuario.setor = Convert.ToInt32(tbxSetor.Text);
            Banco.Cadastro(usuario);
        }
    }
}
