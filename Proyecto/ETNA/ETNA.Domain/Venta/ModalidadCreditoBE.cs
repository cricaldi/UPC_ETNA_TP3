using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class ModalidadCreditoBE
    {

        private Int32 _ModalidadCreditoId;
        public Int32 ModalidadCreditoId
        {
            get { return _ModalidadCreditoId; }

            set { _ModalidadCreditoId = value; }
        }

        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }

            set { _Codigo = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }

            set { _Descripcion = value; }
        }

        private Int32 _DiasCredito;
        public Int32 DiasCredito
        {
            get { return _DiasCredito; }

            set { _DiasCredito = value; }
        }

    }
}
