using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class DireccionBE
    {
        private Int32 _DireccionId;
        public Int32 DireccionId
        {
            get { return _DireccionId; }

            set { _DireccionId = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }

            set { _Descripcion = value; }
        }


    }
}
