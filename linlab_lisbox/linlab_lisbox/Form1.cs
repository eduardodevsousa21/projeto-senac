namespace linlab_lisbox
{

    public partial class Form1 : Form
    {
        List<string> cursos = new List<string>();
        public Form1()
        {
            InitializeComponent();
            cursos.Add("HTML");
            cursos.Add("CSS");
            cursos.Add("PHP");
            cursos.Add("Ruby");

            lxcursos.DataSource = cursos;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void LkCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void lxcursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (tbxcursos.Text == "")
            {
                MessageBox.Show("Digitar curso");
                tbxcursos.Focus();
            }
            else
            {
                //Adcionar texto a caixa de texto da lista de cursos
                cursos.Add(tbxcursos.Text);
                //Limpar a caixa de texto
                tbxcursos.Clear();
                //Posicionar o cursosr na caixa de texto 
                tbxcursos.Focus();
                //Limpar listbox
                lxcursos.DataSource = null;
                //preencher o listbox com a lista cursos atualizada
                lxcursos.DataSource = cursos;
            }
        }

        private void btnremo_Click(object sender, EventArgs e)
        {
            cursos.RemoveAt(lxcursos.SelectedIndex);
            lxcursos.DataSource = null;
            lxcursos.DataSource = cursos;
        }

        private void btnobt_Click(object sender, EventArgs e)
        {
            tbxcursos.Text = cursos[lxcursos.SelectedIndex];

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
