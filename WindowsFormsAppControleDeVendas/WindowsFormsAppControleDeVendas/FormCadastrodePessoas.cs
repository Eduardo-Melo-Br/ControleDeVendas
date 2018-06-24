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
    public partial class FormCadastrodePessoas : Form
    {
        public FormCadastrodePessoas()
        {
            InitializeComponent();
        }

        int[] idPessoas = new int[10];

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_Logradouro_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FormCadastrodePessoas_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRazao_Social_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxIdentificacao_Enter(object sender, EventArgs e)
        {

        }

        private void labelIdentificador1_Click(object sender, EventArgs e)
        {

        }

        private void labelIdentificador2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdentificador2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Identificador3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeAcaoSalvar()
        {
            System.Data.OleDb.OleDbConnection _OleDbConnection = new System.Data.OleDb.OleDbConnection();
            System.Data.OleDb.OleDbCommand _OleDbCommand = new OleDbCommand();
            System.Data.OleDb.OleDbDataReader _DataReader;

            String _strString;
            
            _OleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseControleDeVendas.accdb;Persist Security Info=False;";
            _OleDbConnection.Open();
            _strString = "SELECT Count(*) FROM TabelaControleDeVendaPessoa WHERE ";
            if (radioButtonCPF.Checked)
            {
                _strString = _strString + " CPF = '" + maskedTextBoxCPF.Text + "';";
            }
            if (radioButtonCNPJ.Checked)
            {
                _strString = _strString + " CNPJ = '" + maskedTextBoxCNPJ.Text + "'; ";
            }
            if (radioButtonIdentificadoresEspeciais.Checked)
            {
                _strString = _strString + " (Identificador1 = '" + this.textBoxIdentificador1.Text + "' OR ";
                _strString = _strString + "  Identificador2 = '" + this.textBoxIdentificador2.Text + "' OR ";
                _strString = _strString + "  Identificador3 = '" + this.textBoxIdentificador3.Text + "' OR ";
                _strString = _strString + "  Identificacao1 = '" + this.textBoxIdentificacao1.Text + "' OR ";
                _strString = _strString + "  Identificacao2 = '" + this.textBoxIdentificacao2.Text + "' OR ";
                _strString = _strString + "  Identificacao3 = '" + this.textBoxIdentificacao3.Text + "');";
            }
            _OleDbCommand.CommandText = _strString;
            _OleDbCommand.Connection = _OleDbConnection;
            _DataReader = _OleDbCommand.ExecuteReader();
            _DataReader.Read();
                if (Convert.ToInt16(_DataReader[0].ToString()) > 0)
                {
                    _strString = "UPDATE TabelaControleDeVendaPessoa SET ";
                    _strString = _strString + "PF_PJ = ?, ";
                    _strString = _strString + "CPF = ?, ";
                    _strString = _strString + "CNPJ = ?, ";
                    _strString = _strString + "DOCUMENTO_IDENTIDADE = ?, ";
                    _strString = _strString + "NOME = ?, ";
                    _strString = _strString + "RAZAO_SOCIAL = ?, ";
                    _strString = _strString + "TIPO_LOGRADOURO = ?, ";
                    _strString = _strString + "NOME_LOGRADOURO = ?, ";
                    _strString = _strString + "NUMERO_LOTE = ?, ";
                    _strString = _strString + "COMPLEMENTO = ?, ";
                    _strString = _strString + "BAIRRO = ?, ";
                    _strString = _strString + "LOCALIDADE = ?, ";
                    _strString = _strString + "UF = ?, ";
                    _strString = _strString + "CEP = ?, ";
                    _strString = _strString + "APELIDO = ?, ";
                    _strString = _strString + "NUMERO_TELEFONE_1 = ?, ";
                    _strString = _strString + "TIPO_TELEFONE_1 = ?, ";
                    _strString = _strString + "NUMERO_TELEFONE_2 = ?, ";
                    _strString = _strString + "TIPO_TELEFONE_2 = ?, ";
                    _strString = _strString + "NUMERO_TELEFONE_3 = ?, ";
                    _strString = _strString + "TIPO_TELEFONE_3 = ?, ";
                    _strString = _strString + "OBSERVACOES = ?, ";
                    _strString = _strString + "NASCIMENTO = ?, ";
                    _strString = _strString + "CLIENTE = ?, ";
                    _strString = _strString + "FORNECEDOR = ?, ";
                    _strString = _strString + "PARTICULAR = ?, ";
                    _strString = _strString + "IDENTIFICADOR1 = ?, ";
                    _strString = _strString + "IDENTIFICADOR2 = ?, ";
                    _strString = _strString + "IDENTIFICADOR3 = ?, ";
                    _strString = _strString + "IDENTIFICACAO1 = ?, ";
                    _strString = _strString + "IDENTIFICACAO2 = ?, ";
                    _strString = _strString + "IDENTIFICACAO3 = ?, ";
                    _strString = _strString + "PAIS = ? ";
                    _strString = _strString + "WHERE Código = " + _DataReader[0].ToString();
                    _DataReader.Close();
                    _OleDbCommand.CommandText = _strString;
                    _OleDbCommand.Connection = _OleDbConnection;
                    _OleDbCommand.Parameters.Add("@PF_PJ", OleDbType.Boolean, 1).Value = radioButtonPessoaFisica.Checked;
                    _OleDbCommand.Parameters.Add("@CPF", OleDbType.Char, 14).Value = maskedTextBoxCPF.Text;
                    _OleDbCommand.Parameters.Add("@CNPJ", OleDbType.Char, 18).Value = maskedTextBoxCNPJ.Text;
                    _OleDbCommand.Parameters.Add("@DOCUMENTO_IDENTIDADE", OleDbType.Char, 20).Value = textBoxRG.Text;
                    _OleDbCommand.Parameters.Add("@NOME", OleDbType.Char, 70).Value = textBoxNome.Text;
                    _OleDbCommand.Parameters.Add("@RAZAO_SOCIAL", OleDbType.Char, 140).Value = textBoxRazao_Social.Text;
                    _OleDbCommand.Parameters.Add("@TIPO_LOGRADOURO", OleDbType.Char, 20).Value = comboBoxTipo_Logradouro.Text;
                    _OleDbCommand.Parameters.Add("@NOME_LOGRADOURO", OleDbType.Char, 255).Value = textBoxNome_Logradouro.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_LOTE", OleDbType.Char, 10).Value = maskedTextBoxNumeroLote.Text;
                    _OleDbCommand.Parameters.Add("@COMPLEMENTO", OleDbType.Char, 20).Value = textBoxComplemento.Text;
                    _OleDbCommand.Parameters.Add("@BAIRRO", OleDbType.Char, 255).Value = textBoxBairro.Text;
                    _OleDbCommand.Parameters.Add("@LOCALIDADE", OleDbType.Char, 255).Value = textBoxLocalidade.Text;
                    _OleDbCommand.Parameters.Add("@UF", OleDbType.Char, 2).Value = comboBoxUF.Text.ToUpper();
                    _OleDbCommand.Parameters.Add("@CEP", OleDbType.Char, 8).Value = maskedTextBoxCEP.Text;
                    _OleDbCommand.Parameters.Add("@APELIDO", OleDbType.Char, 50).Value = textBoxApelido.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_1", OleDbType.Char, 20).Value = maskedTextBoxTelefone1.Text;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_1", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_1.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_2", OleDbType.Char, 20).Value = maskedTextBoxTelefone2.Text; ;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_2", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_2.Text; ;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_3", OleDbType.Char, 20).Value = maskedTextBoxTelefone3.Text; ;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_3", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_3.Text;
                    _OleDbCommand.Parameters.Add("@OBSERVACOES", OleDbType.Char, 255).Value = textBoxObservacoes.Text;
                    _OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = maskedTextBox_Nascimento.Text;
                    _OleDbCommand.Parameters.Add("@CLIENTE", OleDbType.Boolean).Value = checkBoxCliente.Checked;
                    _OleDbCommand.Parameters.Add("@FORNECEDOR", OleDbType.Boolean).Value = checkBoxFornecedor.Checked;
                    _OleDbCommand.Parameters.Add("@PARTICULAR", OleDbType.Boolean).Value = checkBoxParticular.Checked;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR1", OleDbType.Char, 50).Value = textBoxIdentificador1.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR2", OleDbType.Char, 50).Value = textBoxIdentificador2.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR3", OleDbType.Char, 50).Value = textBoxIdentificador3.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO1", OleDbType.Char, 50).Value = textBoxIdentificacao1.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO2", OleDbType.Char, 50).Value = textBoxIdentificacao2.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO3", OleDbType.Char, 50).Value = textBoxIdentificacao3.Text;
                    _OleDbCommand.Parameters.Add("@PAIS", OleDbType.Char, 50).Value = textBoxPais.Text;
                    try
                    {
                        _OleDbCommand.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                    }
                }
                else
                {
                    _strString = "INSERT INTO TabelaControleDeVendaPessoa (";
                    _strString = _strString + "PF_PJ, ";
                    _strString = _strString + "CPF, ";
                    _strString = _strString + "CNPJ, ";
                    _strString = _strString + "DOCUMENTO_IDENTIDADE, ";
                    _strString = _strString + "NOME, ";
                    _strString = _strString + "RAZAO_SOCIAL, ";
                    _strString = _strString + "TIPO_LOGRADOURO, ";
                    _strString = _strString + "NOME_LOGRADOURO, ";
                    _strString = _strString + "NUMERO_LOTE, ";
                    _strString = _strString + "COMPLEMENTO, ";
                    _strString = _strString + "BAIRRO, ";
                    _strString = _strString + "LOCALIDADE, ";
                    _strString = _strString + "UF, ";
                    _strString = _strString + "CEP, ";
                    _strString = _strString + "APELIDO, ";
                    _strString = _strString + "NUMERO_TELEFONE_1, ";
                    _strString = _strString + "TIPO_TELEFONE_1, ";
                    _strString = _strString + "NUMERO_TELEFONE_2, ";
                    _strString = _strString + "TIPO_TELEFONE_2, ";
                    _strString = _strString + "NUMERO_TELEFONE_3, ";
                    _strString = _strString + "TIPO_TELEFONE_3, ";
                    _strString = _strString + "OBSERVACOES, ";
                    _strString = _strString + "NASCIMENTO, ";
                    _strString = _strString + "CLIENTE, ";
                    _strString = _strString + "FORNECEDOR, ";
                    _strString = _strString + "PARTICULAR, ";
                    _strString = _strString + "IDENTIFICADOR1, ";
                    _strString = _strString + "IDENTIFICADOR2, ";
                    _strString = _strString + "IDENTIFICADOR3, ";
                    _strString = _strString + "IDENTIFICACAO1, ";
                    _strString = _strString + "IDENTIFICACAO2, ";
                    _strString = _strString + "IDENTIFICACAO3, ";
                    _strString = _strString + "PAIS) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
                    _DataReader.Close();
                    _OleDbCommand.CommandText = _strString;
                    _OleDbCommand.Connection = _OleDbConnection;
                    _OleDbCommand.Parameters.Add("@PF_PJ", OleDbType.Boolean, 1).Value = radioButtonPessoaFisica.Checked;
                    _OleDbCommand.Parameters.Add("@CPF", OleDbType.Char, 14).Value = maskedTextBoxCPF.Text;
                    _OleDbCommand.Parameters.Add("@CNPJ", OleDbType.Char, 18).Value = maskedTextBoxCNPJ.Text;
                    _OleDbCommand.Parameters.Add("@DOCUMENTO_IDENTIDADE", OleDbType.Char, 20).Value = textBoxRG.Text;
                    _OleDbCommand.Parameters.Add("@NOME", OleDbType.Char, 70).Value = textBoxNome.Text;
                    _OleDbCommand.Parameters.Add("@RAZAO_SOCIAL", OleDbType.Char, 140).Value = textBoxRazao_Social.Text;
                    _OleDbCommand.Parameters.Add("@TIPO_LOGRADOURO", OleDbType.Char, 20).Value = comboBoxTipo_Logradouro.Text;
                    _OleDbCommand.Parameters.Add("@NOME_LOGRADOURO", OleDbType.Char, 255).Value = textBoxNome_Logradouro.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_LOTE", OleDbType.Char, 10).Value = maskedTextBoxNumeroLote.Text;
                    _OleDbCommand.Parameters.Add("@COMPLEMENTO", OleDbType.Char, 20).Value = textBoxComplemento.Text;
                    _OleDbCommand.Parameters.Add("@BAIRRO", OleDbType.Char, 255).Value = textBoxBairro.Text;
                    _OleDbCommand.Parameters.Add("@LOCALIDADE", OleDbType.Char, 255).Value = textBoxLocalidade.Text;
                    _OleDbCommand.Parameters.Add("@UF", OleDbType.Char, 2).Value = comboBoxUF.Text.ToUpper();
                    _OleDbCommand.Parameters.Add("@CEP", OleDbType.Char, 8).Value = maskedTextBoxCEP.Text;
                    _OleDbCommand.Parameters.Add("@APELIDO", OleDbType.Char, 50).Value = textBoxApelido.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_1", OleDbType.Char, 20).Value = maskedTextBoxTelefone1.Text;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_1", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_1.Text;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_2", OleDbType.Char, 20).Value = maskedTextBoxTelefone2.Text; ;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_2", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_2.Text; ;
                    _OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_3", OleDbType.Char, 20).Value = maskedTextBoxTelefone3.Text; ;
                    _OleDbCommand.Parameters.Add("@TIPO_TELEFONE_3", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_3.Text;
                    _OleDbCommand.Parameters.Add("@OBSERVACOES", OleDbType.Char, 255).Value = textBoxObservacoes.Text;
                    _OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = maskedTextBox_Nascimento.Text;
                    _OleDbCommand.Parameters.Add("@CLIENTE", OleDbType.Boolean).Value = checkBoxCliente.Checked;
                    _OleDbCommand.Parameters.Add("@FORNECEDOR", OleDbType.Boolean).Value = checkBoxFornecedor.Checked;
                    _OleDbCommand.Parameters.Add("@PARTICULAR", OleDbType.Boolean).Value = checkBoxParticular.Checked;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR1", OleDbType.Char, 50).Value = textBoxIdentificador1.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR2", OleDbType.Char, 50).Value = textBoxIdentificador2.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICADOR3", OleDbType.Char, 50).Value = textBoxIdentificador3.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO1", OleDbType.Char, 50).Value = textBoxIdentificacao1.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO2", OleDbType.Char, 50).Value = textBoxIdentificacao2.Text;
                    _OleDbCommand.Parameters.Add("@IDENTIFICACAO3", OleDbType.Char, 50).Value = textBoxIdentificacao3.Text;
                    _OleDbCommand.Parameters.Add("@PAIS", OleDbType.Char, 50).Value = textBoxPais.Text;
                    try
                    {
                        _OleDbCommand.ExecuteNonQuery();
                    }
                    catch (ArgumentException e)
                    {
                        MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                    }
                }

            _OleDbConnection.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonDeAcaoSalvar();
        }

        private void buttonLocalizar_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection _OleDbConnection = new System.Data.OleDb.OleDbConnection();
            System.Data.OleDb.OleDbCommand _OleDbCommand = new OleDbCommand();
            System.Data.OleDb.OleDbDataReader _DataReader;

            String _strString;

            _OleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseControleDeVendas.accdb;Persist Security Info=False;";
            _OleDbConnection.Open();
            _strString = "SELECT TOP 10 * FROM TabelaControleDeVendaPessoa WHERE ";
            if (radioButtonCPF.Checked)
            {
                _strString = _strString + " CPF = '" + maskedTextBoxCPF.Text + "';";
            }
            if (radioButtonCNPJ.Checked)
            {
                _strString = _strString + " CNPJ = '" + maskedTextBoxCNPJ.Text + "'; ";
            }
            if (radioButtonIdentificadoresEspeciais.Checked)
            {
                _strString = _strString + " (Identificador1 = '" + this.textBoxIdentificador1.Text + "' OR ";
                _strString = _strString + "  Identificador2 = '" + this.textBoxIdentificador2.Text + "' OR ";
                _strString = _strString + "  Identificador3 = '" + this.textBoxIdentificador3.Text + "' OR ";
                _strString = _strString + "  Identificacao1 = '" + this.textBoxIdentificacao1.Text + "' OR ";
                _strString = _strString + "  Identificacao2 = '" + this.textBoxIdentificacao2.Text + "' OR ";
                _strString = _strString + "  Identificacao3 = '" + this.textBoxIdentificacao3.Text + "');";
            }
            _OleDbCommand.CommandText = _strString;
            _OleDbCommand.Connection = _OleDbConnection;
            _DataReader = _OleDbCommand.ExecuteReader();
            // Popular o combobox
            comboBoxPessoas.Items.Clear();
            int intContador = 0;
            while (_DataReader.Read())
            {
                MessageBox.Show(_DataReader[5] + " " + _DataReader[6]);
                comboBoxPessoas.Items.Add(_DataReader[5] + " " + _DataReader[6]);
                idPessoas[intContador] = (int)_DataReader[0];
                intContador++;
            }
            _OleDbConnection.Close();
        }

        private void comboBoxPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection _OleDbConnection = new System.Data.OleDb.OleDbConnection();
            System.Data.OleDb.OleDbCommand _OleDbCommand = new OleDbCommand();
            System.Data.OleDb.OleDbDataReader _DataReader;

            String _strString;

            _OleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseControleDeVendas.accdb;Persist Security Info=False;";
            _OleDbConnection.Open();
            _strString = "SELECT * FROM TabelaControleDeVendaPessoa WHERE [Código] = " + (char)idPessoas[comboBoxPessoas.SelectedIndex];
            _OleDbCommand.CommandText = _strString;
            _OleDbCommand.Connection = _OleDbConnection;
            _DataReader = _OleDbCommand.ExecuteReader();
            if (_DataReader.Read())
            {
                
            }
            _OleDbConnection.Close();
        }
    }
}