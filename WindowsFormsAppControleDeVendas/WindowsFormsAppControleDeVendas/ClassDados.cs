using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsAppControleDeVendas
{
    public class ClassDados
    {
        public System.Data.OleDb.OleDbConnection _OleDbConnection = new System.Data.OleDb.OleDbConnection();
        public System.Data.OleDb.OleDbCommand _OleDbCommand = new OleDbCommand();
        public System.Data.OleDb.OleDbDataReader _DataReader;

        public ClassDados()
        {
            _OleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseControleDeVendas.accdb;Persist Security Info=False;";
            _OleDbConnection.Open();
            _OleDbCommand.Connection = _OleDbConnection;
        }            

        public void Select_TabelaControleDeVendaPessoa()
        {
            String _strSQL;

            _strSQL = "SELECT Código, Nome + Razao_Social FROM TabelaControleDeVendaPessoa Order by Nome + Razao_Social;";
            _OleDbCommand.CommandText = _strSQL;
            _DataReader = _OleDbCommand.ExecuteReader();
        }

        public void Select_TabelaControleDeVendaDepartamento()
        {
            String _strSQL;

            _strSQL = "SELECT * FROM TabelaControleDeVendaDepartamento;";
            _OleDbCommand.CommandText = _strSQL;
            _DataReader = _OleDbCommand.ExecuteReader();
        }

        public void Select_TabelaControleDeVendaProdutos()
        {
            String _strSQL;

            _strSQL = "SELECT EAN13, NOME_PRODUTO_SERVICO FROM TabelaControleDeVendaProdutoServico Order by Nome_Produto_Servico;";
            _OleDbCommand.CommandText = _strSQL;
            _DataReader = _OleDbCommand.ExecuteReader();
        }

        public void Select_TabelaControleDeVendaProdutosEAN13(String _EAN13) 
        {
            String _strSQL;

            _strSQL = "SELECT * FROM TabelaControleDeVendaProdutoServico WHERE EAN13 = '" + _EAN13 + "'";
            _OleDbCommand.CommandText = _strSQL;
            _DataReader = _OleDbCommand.ExecuteReader();
        }

        public void Select_TabelaControleDeVendaOperacao()
        {
            String _strSQL;

            _strSQL = "SELECT TIPO_OPERACAO, DESCRICAO FROM TabelaControleDeVendaTipo_Operacao Order by TIPO_OPERACAO;";
            _OleDbCommand.CommandText = _strSQL;
            _DataReader = _OleDbCommand.ExecuteReader();
        }



    }
}
