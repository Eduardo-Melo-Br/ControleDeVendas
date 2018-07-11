using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsAppControleDeVendas
{
    public partial class FormCadastrodeProdutoseServicos : Form
    {
        String[] _ComboboxDepartamentos = new String[1000];
        String[] idProdutoServico = new String[10];
        Funcoes_Utilitarias _Funcoes_Utilitarias = new Funcoes_Utilitarias();

        public FormCadastrodeProdutoseServicos()
        {
            InitializeComponent();
            Popula_ComboBoxDepartamentos();
            Carregar_ProdutoseServicos();
        }

        private void Popula_ComboBoxDepartamentos()
        {
            ClassDados _dados = new ClassDados();
            _dados.Select_TabelaControleDeVendaDepartamento();
            comboBoxDEPARTAMENTO.Items.Clear();
            while (_dados._DataReader.Read())
            {
                _ComboboxDepartamentos[comboBoxDEPARTAMENTO.Items.Count] = _dados._DataReader["ID"].ToString();
                comboBoxDEPARTAMENTO.Items.Add(_dados._DataReader["DESCRICAO"].ToString());
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Show();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            this.textBoxID.Text = "";
            this.textBoxNOME_PRODUTO_SERVICO.Text = "";
            this.textBoxUNIDADE.Text = "";
            this.maskedTextBoxPRECO_VENDA.Text = "";
            this.comboBoxDEPARTAMENTO.Text = "";
        }

        private void Carregar_ProdutoseServicos()
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT * FROM TabelaControleDeVendaProdutoServico Order by EAN13";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            dataGridViewProdutoseServicos.Rows.Clear();
            dataGridViewProdutoseServicos.AllowUserToAddRows = false;
            dataGridViewProdutoseServicos.AllowUserToDeleteRows = false;
            while (_dados._DataReader.Read())
            {
                string[] _columns = new string[] { _dados._DataReader["EAN13"].ToString(), _dados._DataReader["NOME_PRODUTO_SERVICO"].ToString(), _dados._DataReader["UNIDADE"].ToString(), _dados._DataReader["PRECO_VENDA"].ToString(), _dados._DataReader["DEPARTAMENTO"].ToString() };
                dataGridViewProdutoseServicos.ColumnCount = 5;
                dataGridViewProdutoseServicos.Columns[0].Name = "ID";
                dataGridViewProdutoseServicos.Columns[1].Name = "PRODUTO/SERVIÇO";
                dataGridViewProdutoseServicos.Columns[2].Name = "UNIDADE";
                dataGridViewProdutoseServicos.Columns[3].Name = "PRECO VENDA";
                dataGridViewProdutoseServicos.Columns[4].Name = "DEPARTAMENTO";
                dataGridViewProdutoseServicos.Rows.Add(_columns);
            }
        }

        private void buttonDeAcaoSalvar()
        {
            ClassDados _dados = new ClassDados();
           

            String _strString;

            _strString = "SELECT Count(*) FROM TabelaControleDeVendaProdutoServico WHERE ";
            _strString = _strString + " EAN13 = '" + textBoxID.Text + "';";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            _dados._DataReader.Read();
            if (Convert.ToInt16(_dados._DataReader[0].ToString()) > 0)
            {
                _strString = "UPDATE TabelaControleDeVendaProdutoServico SET ";
                _strString = _strString + "NOME_PRODUTO_SERVICO = ?, ";
                _strString = _strString + "UNIDADE = ?, ";
                _strString = _strString + "PRECO_VENDA = ?, ";
                _strString = _strString + "DEPARTAMENTO = ?, ";
                _strString = _strString + "FOTO = ? ";
                _strString = _strString + "WHERE EAN13 = '" + textBoxID.Text + "'";
                _dados._DataReader.Close();
                _dados._OleDbCommand.CommandText = _strString;
                _dados._OleDbCommand.Parameters.Add("@NOME_PRODUTO_SERVICO", OleDbType.Char, 70).Value = textBoxNOME_PRODUTO_SERVICO.Text;
                _dados._OleDbCommand.Parameters.Add("@UNIDADE", OleDbType.Char, 10).Value = textBoxUNIDADE.Text;
                _dados._OleDbCommand.Parameters.Add("@PRECO_VENDA", OleDbType.Currency).Value = _Funcoes_Utilitarias.Converte_Valor_em_moeda_de_um_MaskedTextBox_para_String(maskedTextBoxPRECO_VENDA.Text);
                _dados._OleDbCommand.Parameters.Add("@DEPARTAMENTO", OleDbType.Char, 14).Value = comboBoxDEPARTAMENTO.Text;
                _dados._OleDbCommand.Parameters.Add("@FOTO", OleDbType.Char, 255).Value = pictureBox1.ImageLocation + "";
                try
                {
                    _dados._OleDbCommand.ExecuteNonQuery();
                    MessageBox.Show("Produto/Serviço atualizado ...");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                }
            }
            else
            {
                _strString = "INSERT INTO TabelaControleDeVendaProdutoServico (";
                _strString = _strString + "EAN13, ";
                _strString = _strString + "NOME_PRODUTO_SERVICO, ";
                _strString = _strString + "UNIDADE, ";
                _strString = _strString + "PRECO_VENDA, ";
                _strString = _strString + "DEPARTAMENTO, ";
                _strString = _strString + "FOTO) ";
                _strString = _strString + " VALUES (?,?,?,?,?,?);";
                _dados._DataReader.Close();
                _dados._OleDbCommand.CommandText = _strString;
                _dados._OleDbCommand.Parameters.Add("@EAN13", OleDbType.Char, 13).Value = textBoxID.Text;
                _dados._OleDbCommand.Parameters.Add("@NOME_PRODUTO_SERVICO", OleDbType.Char, 70).Value = textBoxNOME_PRODUTO_SERVICO.Text;
                _dados._OleDbCommand.Parameters.Add("@UNIDADE", OleDbType.Char, 10).Value = textBoxUNIDADE.Text;
                _dados._OleDbCommand.Parameters.Add("@PRECO_VENDA", OleDbType.Currency).Value = _Funcoes_Utilitarias.Converte_Valor_em_moeda_de_um_MaskedTextBox_para_String( maskedTextBoxPRECO_VENDA.Text);
                _dados._OleDbCommand.Parameters.Add("@DEPARTAMENTO", OleDbType.Char, 14).Value = comboBoxDEPARTAMENTO.Text;
                _dados._OleDbCommand.Parameters.Add("@FOTO", OleDbType.Char, 255).Value = pictureBox1.ImageLocation+"";

                try
                {
                    _dados._OleDbCommand.ExecuteNonQuery();
                    MessageBox.Show("Produto/Serviço salvo ...");
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                }
            }
            _dados._OleDbConnection.Close();
            Carregar_ProdutoseServicos();
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonDeAcaoSalvar();
        }

        private void buttonLocalizar_Click(object sender, EventArgs e)
        {
            SUB_Localizar();
        }

        private void SUB_Localizar()
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT TOP 10 * FROM TabelaControleDeVendaProdutoServico WHERE ";
            if (radioButtonEAN13.Checked)
            {
                _strString = _strString + " EAN13 = '" + textBoxID.Text + "';";
            }
            if (radioButtonDescricao.Checked)
            {
                _strString = _strString + " NOME_PRODUTO_SERVICO = '" + textBoxNOME_PRODUTO_SERVICO.Text + "'; ";
            }
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            // Popular o combobox
            comboBoxLocalizar.Items.Clear();
            int intContador = 0;
            while (_dados._DataReader.Read())
            {
                comboBoxLocalizar.Items.Add(_dados._DataReader[0] + " " + _dados._DataReader[1]);
                idProdutoServico[intContador] = _dados._DataReader[0].ToString();
                intContador++;
            }
            _dados._OleDbConnection.Close();

        }

        private void comboBoxLocalizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SUB_Carregar_ID(comboBoxLocalizar.SelectedIndex);
        }

        private void SUB_Carregar_ID(int _id)
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT * FROM TabelaControleDeVendaProdutoServico WHERE [EAN13] = ?;";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._OleDbCommand.Parameters.Add("@EAN13", OleDbType.Char, 14).Value = idProdutoServico[_id];
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            if (_dados._DataReader.Read())
            {
                textBoxID.Text = _dados._DataReader[0].ToString();
                textBoxNOME_PRODUTO_SERVICO.Text = _dados._DataReader[1].ToString();
                textBoxUNIDADE.Text = _dados._DataReader["UNIDADE"].ToString();
                maskedTextBoxPRECO_VENDA.Text = _Funcoes_Utilitarias.Converte_Valor_em_moeda_de_um_Texto_para_MaskedTextBox(_dados._DataReader["PRECO_VENDA"].ToString(),12);
                comboBoxDEPARTAMENTO.Text = _dados._DataReader["DEPARTAMENTO"].ToString();
            }
            _dados._OleDbConnection.Close();

        }

        private void dataGridViewProdutoseServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProdutoseServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                radioButtonEAN13.Checked = true;
                textBoxID.Text = dataGridViewProdutoseServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            if (e.ColumnIndex == 1)
            {
                radioButtonDescricao.Checked = true;
                textBoxNOME_PRODUTO_SERVICO.Text = dataGridViewProdutoseServicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            SUB_Localizar();
            SUB_Carregar_ID(0);
        }

        private void textBoxNOME_PRODUTO_SERVICO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
