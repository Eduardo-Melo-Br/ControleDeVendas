using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControleDeVendas
{
    class ClassMinhaLista
    {
        private String _Item;
        private object _ID;

        public ClassMinhaLista (String _Item, object _ID)
        {
            this._Item = _Item;
            this._ID = _ID;
        }

        public String Item()
        {
            return this._Item;
        }

        public object ItemData()
        {
            return this._ID;
        }
    }
}
