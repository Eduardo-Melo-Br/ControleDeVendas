using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppControleDeVendas
{
    public partial class FormCadastrodeDepartamentos : Form
    {
        String[] idDepartamentos = new String [10];

        public FormCadastrodeDepartamentos()
        {
            InitializeComponent();
            Carregar_Departamentos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonDeAcaoSalvar();
        }

        private void buttonDeAcaoSalvar()
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT Count(*) FROM TabelaControleDeVendaDepartamento WHERE ";
            _strString = _strString + " ID = '" + textBoxID.Text + "';";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            _dados._DataReader.Read();
            if (Convert.ToInt16(_dados._DataReader[0].ToString()) > 0)
            {
                _strString = "UPDATE TabelaControleDeVendaDepartamento SET ";
                _strString = _strString + "DESCRICAO = ? ";
                _strString = _strString + "WHERE ID = '" + textBoxID.Text + "'";
                _dados._DataReader.Close();
                _dados._OleDbCommand.CommandText = _strString;
                _dados._OleDbCommand.Parameters.Add("@DESCRICAO", OleDbType.Char, 70).Value = textBoxDescricao.Text;
                try
                {
                        _dados._OleDbCommand.ExecuteNonQuery();
                        MessageBox.Show("Departamento atualizado ...");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                    }
                }
                else
                {
                    _strString = "INSERT INTO TabelaControleDeVendaDepartamento (";
                    _strString = _strString + "ID, ";
                    _strString = _strString + "DESCRICAO) ";
                    _strString = _strString + " VALUES (?,?);";
                    _dados._DataReader.Close();
                    _dados._OleDbCommand.CommandText = _strString;
                    _dados._OleDbCommand.Parameters.Add("@ID", OleDbType.Char, 14).Value = textBoxID.Text;
                    _dados._OleDbCommand.Parameters.Add("@DESCRICAO", OleDbType.Char, 70).Value = textBoxDescricao.Text;
                    try
                    {
                        _dados._OleDbCommand.ExecuteNonQuery();
                        MessageBox.Show("Departamento salvo ...");
                    }
                    catch (ArgumentException e)
                    {
                        MessageBox.Show(e.Message.ToString() + " " + e.HResult.ToString(), "Ops! Ocorreu uma Falha ... Peço desculpa, vou verificar ...");
                    }
                }
                _dados._OleDbConnection.Close();
            Carregar_Departamentos();
        }

        private void SUB_Localizar()
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT TOP 10 * FROM TabelaControleDeVendaDepartamento WHERE ";
            if (radioButtonID.Checked)
            {
                _strString = _strString + " ID = '" + textBoxID.Text + "';";
            }
            if (radioButtonDescricao.Checked)
            {
                _strString = _strString + " DESCRICAO = '" + textBoxDescricao.Text + "'; ";
            }
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            // Popular o combobox
            comboBoxLocalizar.Items.Clear();
            int intContador = 0;
            while (_dados._DataReader.Read())
            {
                comboBoxLocalizar.Items.Add(_dados._DataReader[0] + " " + _dados._DataReader[1]);
                idDepartamentos[intContador] = _dados._DataReader[0].ToString();
                intContador++;
            }
            _dados._OleDbConnection.Close();

        }

        private void buttonLocalizar_Click(object sender, EventArgs e)
        {
            SUB_Localizar();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxDescricao.Text = "";
        }

        private void Carregar_Departamentos()
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT * FROM TabelaControleDeVendaDepartamento Order by ID";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            while (_dados._DataReader.Read())
            {
                string[] _columns = new string[] {_dados._DataReader[0].ToString(), _dados._DataReader[1].ToString() };
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Departamento";
                dataGridView1.Rows.Add(_columns);
            }
            _dados._OleDbConnection.Close();
        }

        private void SUB_Carregar_ID(int _id)
        {
            ClassDados _dados = new ClassDados();

            String _strString;

            _strString = "SELECT * FROM TabelaControleDeVendaDepartamento WHERE [ID] = ?;";
            _dados._OleDbCommand.CommandText = _strString;
            _dados._OleDbCommand.Parameters.Add("@ID", OleDbType.Char, 14).Value = idDepartamentos[_id];
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            if (_dados._DataReader.Read())
            {
                textBoxID.Text = _dados._DataReader[0].ToString();
                textBoxDescricao.Text = _dados._DataReader[1].ToString();
            }
            _dados._OleDbConnection.Close();

        }

        private void comboBoxLocalizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SUB_Carregar_ID(comboBoxLocalizar.SelectedIndex);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                radioButtonID.Checked = true;
                textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            if (e.ColumnIndex == 1)
            {
                radioButtonDescricao.Checked = true;
                textBoxDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            SUB_Localizar();
            SUB_Carregar_ID(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
