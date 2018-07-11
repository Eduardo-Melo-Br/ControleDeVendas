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
            FormSplash xForm = new FormSplash();
            xForm.Show();
            System.Threading.Thread.Sleep(14000);
            xForm.Close();
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
            FormCadastrodeProdutoseServicos xForm = new FormCadastrodeProdutoseServicos();
            xForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastrodeDepartamentos xForm = new FormCadastrodeDepartamentos();
            xForm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 xForm = new AboutBox1();
            xForm.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLancamentoDeHistorico xForm = new FormLancamentoDeHistorico();
            xForm.Show();
        }
    }
}
