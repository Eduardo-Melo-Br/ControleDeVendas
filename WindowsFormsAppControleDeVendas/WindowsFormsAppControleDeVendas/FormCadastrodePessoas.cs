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
            ClassDados _dados = new ClassDados();

            String _strString;
            Boolean _Salvar;
            
            _strString = "SELECT Count(*) FROM TabelaControleDeVendaPessoa WHERE ";
            if (radioButtonCPF.Checked)
            {
                _strString = _strString + " CPF = '" + maskedTextBoxCPF.Text + "';";
                _Salvar = true;
            } else if (radioButtonCNPJ.Checked)
            {
                _strString = _strString + " CNPJ = '" + maskedTextBoxCNPJ.Text + "'; ";
                _Salvar = true;
            }
            else if (radioButtonIdentificadoresEspeciais.Checked)
            {
                _strString = _strString + " (Identificador1 = '" + this.textBoxIdentificador1.Text + "' OR ";
                _strString = _strString + "  Identificador2 = '" + this.textBoxIdentificador2.Text + "' OR ";
                _strString = _strString + "  Identificador3 = '" + this.textBoxIdentificador3.Text + "' OR ";
                _strString = _strString + "  Identificacao1 = '" + this.textBoxIdentificacao1.Text + "' OR ";
                _strString = _strString + "  Identificacao2 = '" + this.textBoxIdentificacao2.Text + "' OR ";
                _strString = _strString + "  Identificacao3 = '" + this.textBoxIdentificacao3.Text + "');";
                _Salvar = true;
            } else
            {
                MessageBox.Show("Selecione algum dos critérios CPF/CNPJ/Identificadores especiais");
                _Salvar = false;
            }

            if (_Salvar)
            {
                _dados._OleDbCommand.CommandText = _strString;
                _dados._OleDbCommand.Connection = _dados._OleDbConnection;
                _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
                _dados._DataReader.Read();
                if (Convert.ToInt16(_dados._DataReader[0].ToString()) > 0)
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
                    _strString = _strString + "PAIS = ?, ";
                    _strString = _strString + "FOTO = ? ";
                    _strString = _strString + "WHERE Código = " + _dados._DataReader[0].ToString();
                    _dados._DataReader.Close();
                    _dados._OleDbCommand.CommandText = _strString;
                    _dados._OleDbCommand.Connection = _dados._OleDbConnection;
                    _dados._OleDbCommand.Parameters.Add("@PF_PJ", OleDbType.Boolean, 1).Value = radioButtonPessoaFisica.Checked;
                    _dados._OleDbCommand.Parameters.Add("@CPF", OleDbType.Char, 14).Value = maskedTextBoxCPF.Text;
                    _dados._OleDbCommand.Parameters.Add("@CNPJ", OleDbType.Char, 18).Value = maskedTextBoxCNPJ.Text;
                    _dados._OleDbCommand.Parameters.Add("@DOCUMENTO_IDENTIDADE", OleDbType.Char, 20).Value = textBoxRG.Text;
                    _dados._OleDbCommand.Parameters.Add("@NOME", OleDbType.Char, 70).Value = textBoxNome.Text;
                    _dados._OleDbCommand.Parameters.Add("@RAZAO_SOCIAL", OleDbType.Char, 140).Value = textBoxRazao_Social.Text;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_LOGRADOURO", OleDbType.Char, 20).Value = comboBoxTipo_Logradouro.Text;
                    _dados._OleDbCommand.Parameters.Add("@NOME_LOGRADOURO", OleDbType.Char, 255).Value = textBoxNome_Logradouro.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_LOTE", OleDbType.Char, 10).Value = maskedTextBoxNumeroLote.Text;
                    _dados._OleDbCommand.Parameters.Add("@COMPLEMENTO", OleDbType.Char, 20).Value = textBoxComplemento.Text;
                    _dados._OleDbCommand.Parameters.Add("@BAIRRO", OleDbType.Char, 255).Value = textBoxBairro.Text;
                    _dados._OleDbCommand.Parameters.Add("@LOCALIDADE", OleDbType.Char, 255).Value = textBoxLocalidade.Text;
                    _dados._OleDbCommand.Parameters.Add("@UF", OleDbType.Char, 2).Value = comboBoxUF.Text.ToUpper();
                    _dados._OleDbCommand.Parameters.Add("@CEP", OleDbType.Char, 8).Value = maskedTextBoxCEP.Text;
                    _dados._OleDbCommand.Parameters.Add("@APELIDO", OleDbType.Char, 50).Value = textBoxApelido.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_1", OleDbType.Char, 20).Value = maskedTextBoxTelefone1.Text;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_1", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_1.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_2", OleDbType.Char, 20).Value = maskedTextBoxTelefone2.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_2", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_2.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_3", OleDbType.Char, 20).Value = maskedTextBoxTelefone3.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_3", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_3.Text;
                    _dados._OleDbCommand.Parameters.Add("@OBSERVACOES", OleDbType.Char, 255).Value = textBoxObservacoes.Text;
                    if (maskedTextBox_Nascimento.Text == "  /  /    ")
                    {
                        _dados._OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = null;
                    }
                    else
                    {
                        _dados._OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = maskedTextBox_Nascimento.Text;
                    }
                    _dados._OleDbCommand.Parameters.Add("@CLIENTE", OleDbType.Boolean).Value = checkBoxCliente.Checked;
                    _dados._OleDbCommand.Parameters.Add("@FORNECEDOR", OleDbType.Boolean).Value = checkBoxFornecedor.Checked;
                    _dados._OleDbCommand.Parameters.Add("@PARTICULAR", OleDbType.Boolean).Value = checkBoxParticular.Checked;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR1", OleDbType.Char, 50).Value = textBoxIdentificador1.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR2", OleDbType.Char, 50).Value = textBoxIdentificador2.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR3", OleDbType.Char, 50).Value = textBoxIdentificador3.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO1", OleDbType.Char, 50).Value = textBoxIdentificacao1.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO2", OleDbType.Char, 50).Value = textBoxIdentificacao2.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO3", OleDbType.Char, 50).Value = textBoxIdentificacao3.Text;
                    _dados._OleDbCommand.Parameters.Add("@PAIS", OleDbType.Char, 50).Value = textBoxPais.Text;
                    _dados._OleDbCommand.Parameters.Add("@FOTO", OleDbType.Char, 255).Value = pictureBox1.ImageLocation;
                    try
                    {
                        _dados._OleDbCommand.ExecuteNonQuery();
                        MessageBox.Show("Pessoa atualizada ...");
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
                    _strString = _strString + "PAIS, FOTO) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
                    _dados._DataReader.Close();
                    _dados._OleDbCommand.CommandText = _strString;
                    _dados._OleDbCommand.Connection = _dados._OleDbConnection;
                    _dados._OleDbCommand.Parameters.Add("@PF_PJ", OleDbType.Boolean, 1).Value = radioButtonPessoaFisica.Checked;
                    _dados._OleDbCommand.Parameters.Add("@CPF", OleDbType.Char, 14).Value = maskedTextBoxCPF.Text;
                    _dados._OleDbCommand.Parameters.Add("@CNPJ", OleDbType.Char, 18).Value = maskedTextBoxCNPJ.Text;
                    _dados._OleDbCommand.Parameters.Add("@DOCUMENTO_IDENTIDADE", OleDbType.Char, 20).Value = textBoxRG.Text;
                    _dados._OleDbCommand.Parameters.Add("@NOME", OleDbType.Char, 70).Value = textBoxNome.Text;
                    _dados._OleDbCommand.Parameters.Add("@RAZAO_SOCIAL", OleDbType.Char, 140).Value = textBoxRazao_Social.Text;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_LOGRADOURO", OleDbType.Char, 20).Value = comboBoxTipo_Logradouro.Text;
                    _dados._OleDbCommand.Parameters.Add("@NOME_LOGRADOURO", OleDbType.Char, 255).Value = textBoxNome_Logradouro.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_LOTE", OleDbType.Char, 10).Value = maskedTextBoxNumeroLote.Text;
                    _dados._OleDbCommand.Parameters.Add("@COMPLEMENTO", OleDbType.Char, 20).Value = textBoxComplemento.Text;
                    _dados._OleDbCommand.Parameters.Add("@BAIRRO", OleDbType.Char, 255).Value = textBoxBairro.Text;
                    _dados._OleDbCommand.Parameters.Add("@LOCALIDADE", OleDbType.Char, 255).Value = textBoxLocalidade.Text;
                    _dados._OleDbCommand.Parameters.Add("@UF", OleDbType.Char, 2).Value = comboBoxUF.Text.ToUpper();
                    _dados._OleDbCommand.Parameters.Add("@CEP", OleDbType.Char, 8).Value = maskedTextBoxCEP.Text;
                    _dados._OleDbCommand.Parameters.Add("@APELIDO", OleDbType.Char, 50).Value = textBoxApelido.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_1", OleDbType.Char, 20).Value = maskedTextBoxTelefone1.Text;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_1", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_1.Text;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_2", OleDbType.Char, 20).Value = maskedTextBoxTelefone2.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_2", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_2.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@NUMERO_TELEFONE_3", OleDbType.Char, 20).Value = maskedTextBoxTelefone3.Text; ;
                    _dados._OleDbCommand.Parameters.Add("@TIPO_TELEFONE_3", OleDbType.Char, 20).Value = comboBoxTipo_Telefone_3.Text;
                    _dados._OleDbCommand.Parameters.Add("@OBSERVACOES", OleDbType.Char, 255).Value = textBoxObservacoes.Text;
                    if (maskedTextBox_Nascimento.Text == "  /  /")
                    {
                        _dados._OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = "01/01/1700"; // Data para sem nascimento
                    }
                    else
                    {
                        _dados._OleDbCommand.Parameters.Add("@NASCIMENTO", OleDbType.Date).Value = maskedTextBox_Nascimento.Text;
                    }
                    _dados._OleDbCommand.Parameters.Add("@CLIENTE", OleDbType.Boolean).Value = checkBoxCliente.Checked;
                    _dados._OleDbCommand.Parameters.Add("@FORNECEDOR", OleDbType.Boolean).Value = checkBoxFornecedor.Checked;
                    _dados._OleDbCommand.Parameters.Add("@PARTICULAR", OleDbType.Boolean).Value = checkBoxParticular.Checked;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR1", OleDbType.Char, 50).Value = textBoxIdentificador1.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR2", OleDbType.Char, 50).Value = textBoxIdentificador2.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICADOR3", OleDbType.Char, 50).Value = textBoxIdentificador3.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO1", OleDbType.Char, 50).Value = textBoxIdentificacao1.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO2", OleDbType.Char, 50).Value = textBoxIdentificacao2.Text;
                    _dados._OleDbCommand.Parameters.Add("@IDENTIFICACAO3", OleDbType.Char, 50).Value = textBoxIdentificacao3.Text;
                    _dados._OleDbCommand.Parameters.Add("@PAIS", OleDbType.Char, 50).Value = textBoxPais.Text;
                    _dados._OleDbCommand.Parameters.Add("@FOTO", OleDbType.Char, 255).Value = pictureBox1.ImageLocation;
                    try
                    {
                        _dados._OleDbCommand.ExecuteNonQuery();
                        MessageBox.Show("Pessoa salva ...");
                    }
                    catch (ArgumentException e)
                    {
                        MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                    }
                }
                _dados._OleDbConnection.Close();
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonDeAcaoSalvar();
        }

        private void buttonLocalizar_Click(object sender, EventArgs e)
        {
            ClassDados _dados = new ClassDados();

            //_dados.Main();

            String _strString;
            
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
            if (radioButtonNomeRazaoSocialApelido.Checked)
            {
                _strString = _strString + " (NOME = '" + this.comboBoxPessoas.Text + "' OR ";
                _strString = _strString + "  RAZAO_SOCIAL = '" + this.comboBoxPessoas.Text + "' OR ";
                _strString = _strString + "  APELIDO = '" + this.comboBoxPessoas.Text + "')";
            }
            _dados._OleDbCommand.CommandText = _strString;
            _dados._OleDbCommand.Connection = _dados._OleDbConnection;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            // Popular o combobox
            comboBoxPessoas.Items.Clear();
            int intContador = 0;
            while (_dados._DataReader.Read())
            {
                comboBoxPessoas.Items.Add(_dados._DataReader[5] + " " + _dados._DataReader[6]);
                idPessoas[intContador] = (int)_dados._DataReader[0];
                intContador++;
            }
            _dados._OleDbConnection.Close();
        }

        private void comboBoxPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT * FROM TabelaControleDeVendaPessoa WHERE [Código] = ?;";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._OleDbCommand.Connection = _dados._OleDbConnection;
            _dados._OleDbCommand.Parameters.Add("@ID", OleDbType.Integer).Value = idPessoas[comboBoxPessoas.SelectedIndex];
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            if (_dados._DataReader.Read())
            {
                if (Convert.ToBoolean(_dados._DataReader["PF_PJ"]) == true)
                {
                    radioButtonPessoaFisica.Checked = true;
                    radioButtonPessoaJuridica.Checked = false;
                } else
                {
                    radioButtonPessoaFisica.Checked = false;
                    radioButtonPessoaJuridica.Checked = true;
                }
                maskedTextBoxCPF.Text = Convert.ToString(_dados._DataReader["CPF"]);
                maskedTextBoxCNPJ.Text = Convert.ToString(_dados._DataReader["CNPJ"]);
                textBoxRG.Text = Convert.ToString(_dados._DataReader["DOCUMENTO_IDENTIDADE"]);
                textBoxNome.Text = Convert.ToString(_dados._DataReader["NOME"]);
                textBoxRazao_Social.Text = Convert.ToString(_dados._DataReader["RAZAO_SOCIAL"]);
                comboBoxTipo_Logradouro.Text = Convert.ToString(_dados._DataReader["TIPO_LOGRADOURO"]);
                textBoxNome_Logradouro.Text = Convert.ToString(_dados._DataReader["NOME_LOGRADOURO"]);
                maskedTextBoxNumeroLote.Text = Convert.ToString(_dados._DataReader["NUMERO_LOTE"]);
                textBoxComplemento.Text = Convert.ToString(_dados._DataReader["COMPLEMENTO"]);
                textBoxBairro.Text = Convert.ToString(_dados._DataReader["BAIRRO"]);
                textBoxLocalidade.Text = Convert.ToString(_dados._DataReader["LOCALIDADE"]);
                comboBoxUF.Text = Convert.ToString(_dados._DataReader["UF"]);
                maskedTextBoxCEP.Text = Convert.ToString(_dados._DataReader["CEP"]);
                textBoxApelido.Text = Convert.ToString(_dados._DataReader["APELIDO"]);
                maskedTextBoxTelefone1.Text = Convert.ToString(_dados._DataReader["NUMERO_TELEFONE_1"]);
                comboBoxTipo_Telefone_1.Text = Convert.ToString(_dados._DataReader["TIPO_TELEFONE_1"]);
                maskedTextBoxTelefone2.Text = Convert.ToString(_dados._DataReader["NUMERO_TELEFONE_2"]);
                comboBoxTipo_Telefone_2.Text = Convert.ToString(_dados._DataReader["TIPO_TELEFONE_2"]);
                maskedTextBoxTelefone3.Text = Convert.ToString(_dados._DataReader["NUMERO_TELEFONE_3"]);
                comboBoxTipo_Telefone_3.Text = Convert.ToString(_dados._DataReader["TIPO_TELEFONE_3"]);
                textBoxObservacoes.Text = Convert.ToString(_dados._DataReader["OBSERVACOES"]);
                if (Convert.ToString(_dados._DataReader["NASCIMENTO"]) == "01/01/1700 00:00:00")
                {
                    maskedTextBox_Nascimento.Text = "  /  /";
                } else
                {
                    maskedTextBox_Nascimento.Text = Convert.ToString(_dados._DataReader["NASCIMENTO"]);
                }
                
                checkBoxCliente.Checked = Convert.ToBoolean(_dados._DataReader["CLIENTE"]);
                checkBoxFornecedor.Checked = Convert.ToBoolean(_dados._DataReader["FORNECEDOR"]);
                checkBoxParticular.Checked = Convert.ToBoolean(_dados._DataReader["PARTICULAR"]);
                textBoxIdentificador1.Text = Convert.ToString(_dados._DataReader["IDENTIFICADOR1"]);
                textBoxIdentificador2.Text = Convert.ToString(_dados._DataReader["IDENTIFICADOR2"]);
                textBoxIdentificador3.Text = Convert.ToString(_dados._DataReader["IDENTIFICADOR3"]);
                textBoxIdentificacao1.Text = Convert.ToString(_dados._DataReader["IDENTIFICACAO1"]);
                textBoxIdentificacao2.Text = Convert.ToString(_dados._DataReader["IDENTIFICACAO2"]);
                textBoxIdentificacao3.Text = Convert.ToString(_dados._DataReader["IDENTIFICACAO3"]);
                textBoxPais.Text = Convert.ToString(_dados._DataReader["PAIS"]);
                pictureBox1.ImageLocation = Convert.ToString(_dados._DataReader["FOTO"]);
            }
            _dados._OleDbConnection.Close();
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Show();
            }
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCNPJ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNomeRazaoSocialApelido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxRG.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxCNPJ.Text = "";
            textBoxApelido.Text = "";
            textBoxNome.Text = "";
            textBoxRazao_Social.Text = "";
            maskedTextBox_Nascimento.Text = "";
            maskedTextBoxDesde.Text = "";
            pictureBox1.ImageLocation = "";

        }

        private void textBoxRG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}