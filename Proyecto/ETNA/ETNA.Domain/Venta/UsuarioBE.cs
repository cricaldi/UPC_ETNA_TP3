using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class UsuarioBE
    {

        private Int32 _ID;
        public Int32 ID
        {
            get { return _ID; }

            set { _ID = value; }
        }

        private string _Pass;
        public string Pass
        {
            get { return _Pass; }

            set { _Pass = value; }
        }

    }
}
