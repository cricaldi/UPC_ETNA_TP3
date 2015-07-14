using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class FacturaDetalleBE
    {
        private Int32 _FacturaDetalleId;
        public Int32 FacturaDetalleId
        {
            get { return _FacturaDetalleId; }

            set { _FacturaDetalleId = value; }
        }

        private Int32 _FacturaId;
        public Int32 FacturaId
        {
            get { return _FacturaId; }

            set { _FacturaId = value; }
        }

        private Int32 _ProductoId;
        public Int32 ProductoId
        {
            get { return _ProductoId; }

            set { _ProductoId = value; }
        }

        private decimal _Cantidad;
        public decimal Cantidad
        {
            get { return _Cantidad; }

            set { _Cantidad = value; }
        }

        private decimal _Valortotal;
        public decimal Valortotal
        {
            get { return _Valortotal; }

            set { _Valortotal = value; }
        }

        private string _Observacion;
        public string Observacion
        {
            get { return _Observacion; }

            set { _Observacion = value; }
        }

        private Int32 _CodigoReq;
        public Int32 CodigoReq
        {
            get { return _CodigoReq; }

            set { _CodigoReq = value; }
        }
    }
}
