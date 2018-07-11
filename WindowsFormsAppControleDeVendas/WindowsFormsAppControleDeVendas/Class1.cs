using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControleDeVendas
{
    class Funcoes_Utilitarias
    {
        public String Converte_Valor_em_moeda_de_um_MaskedTextBox_para_String(String _Texto)
        {
            String _strRetorno = "";

            for (int i = 2; i <= _Texto.Length, i++)
            {
                if (_Texto.Substring(i,1) == "0")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "1")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "2")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "3")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "4")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "5")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "6")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "7")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "8")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == "9")
                {
                    _strRetorno = _strRetorno + _Texto.Substring(i, 1);
                }
                if (_Texto.Substring(i, 1) == ",")
                {
                    _strRetorno = _strRetorno + ".";
                }

            }
            return _strRetorno;
        }
    }
}
