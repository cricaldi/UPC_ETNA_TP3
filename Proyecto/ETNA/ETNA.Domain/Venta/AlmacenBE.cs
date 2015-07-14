using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class AlmacenBE
    {
        private Int32 _AlmacenId;
        public Int32 AlmacenId
        {
            get { return _AlmacenId; }

            set { _AlmacenId = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }

            set { _Nombre = value; }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }

            set { _Direccion = value; }
        }

        private Int32 _Tipo;
        public Int32 Tipo
        {
            get { return _Tipo; }

            set { _Tipo = value; }
        }

        private Int32 _AreaEnM2;
        public Int32 AreaEnM2
        {
            get { return _AreaEnM2; }

            set { _AreaEnM2 = value; }
        }
    }
}
