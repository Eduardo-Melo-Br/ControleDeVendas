using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppControleDeVendas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrodePessoas xForm = new FormCadastrodePessoas();
            xForm.Show();
        }

        private void produtosEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
