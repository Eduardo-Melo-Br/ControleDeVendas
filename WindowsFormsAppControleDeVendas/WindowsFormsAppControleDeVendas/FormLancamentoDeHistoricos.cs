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
    public partial class FormLancamentoDeHistorico : Form
    {
        List <String> _Produtos = new List<String>();
        List <int> _Pessoas = new List<int>();
        List <int> _ID = new List<int>();

        public FormLancamentoDeHistorico()
        {
            InitializeComponent();
            Popula_Pessoas();
            Popula_Produtos();
            Popula_Operacao();
            maskedTextBoxDataHora.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        public void Popula_Pessoas()
        {
            ClassDados _dados = new ClassDados();

            _dados.Select_TabelaControleDeVendaPessoa();
            comboBoxPessoas.Items.Clear();
            while (_dados._DataReader.Read())
            {
                comboBoxPessoas.Items.Add(_dados._DataReader[1].ToString());
                _Pessoas.Add((int)_dados._DataReader[0]);
            }
        }

        public void Popula_Produtos()
        {
            ClassDados _dados = new ClassDados();

            _dados.Select_TabelaControleDeVendaProdutos();
            comboBoxProdutos_Servicos.Items.Clear();
            while (_dados._DataReader.Read())
            {
                comboBoxProdutos_Servicos.Items.Add(_dados._DataReader[1].ToString());
                _Produtos.Add(_dados._DataReader[0].ToString());
            }
        }

        public void Popula_Operacao()
        {
            ClassDados _dados = new ClassDados();

            _dados.Select_TabelaControleDeVendaOperacao();
            comboBoxOperacao.Items.Clear();
            while (_dados._DataReader.Read())
            {
                comboBoxOperacao.Items.Add(_dados._DataReader[1].ToString());
                _ID.Add((int)_dados._DataReader[0]);
            }
        }

        private void comboBoxProdutos_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassDados _dados = new ClassDados();
            Funcoes_Utilitarias _Funcoes_Utilitarias = new Funcoes_Utilitarias();
            _dados.Select_TabelaControleDeVendaProdutosEAN13(_Produtos[comboBoxProdutos_Servicos.SelectedIndex]);
            if (_dados._DataReader.Read())
            {
                maskedTextBoxPreco.Text = _Funcoes_Utilitarias.Converte_Valor_em_moeda_de_um_Texto_para_MaskedTextBox(_dados._DataReader["PRECO_VENDA"].ToString(), 8);
            }
            
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            maskedTextBoxDataHora.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            comboBoxOperacao.SelectedValue = "VENDA";
        }

        private void buttonDataHora_Click(object sender, EventArgs e)
        {
            maskedTextBoxDataHora.Text = "";
        }

        private void maskedTextBoxPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
