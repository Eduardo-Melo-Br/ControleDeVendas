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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            ClassDados _dados = new ClassDados();
            int _intRegistros = 0;
            int _sorteio = 0;
            Random _ramdom = new Random();
            _dados._OleDbCommand.CommandText = "SELECT * FROM Promessa;";
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            while (_dados._DataReader.Read())
            {
                _intRegistros++;
            }
            _sorteio = _ramdom.Next(1, _intRegistros+1);
            _dados._DataReader.Close();
            _dados._DataReader = _dados._OleDbCommand.ExecuteReader();
            if (_sorteio > 1)
            {
                for (int i = 1;i <= _sorteio;i++)
                {
                    _dados._DataReader.Read();
                }
            }
            richTextBoxTexto.Text = _dados._DataReader["Texto"] + " " + _dados._DataReader["Referencia"];
        }
    }
}
