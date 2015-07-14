using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class CuentaDetalleVentaBE
    {
        private Int32 _CuotaqVentaDetalleId;
        public Int32 CuotaqVentaDetalleId
        {
            get { return _CuotaqVentaDetalleId; }

            set { _CuotaqVentaDetalleId = value; }
        }

        private Int32 _CuotaId;
        public Int32 CuotaId
        {
            get { return _CuotaId; }

            set { _CuotaId = value; }
        }

        private Int32 _ProductoId;
        public Int32 ProductoId
        {
            get { return _ProductoId; }

            set { _ProductoId = value; }
        }

        private Int32 _IdVendedor;
        public Int32 IdVendedor
        {
            get { return _IdVendedor; }

            set { _IdVendedor = value; }
        }

        private Int32 _ZonaId;
        public Int32 ZonaId
        {
            get { return _ZonaId; }

            set { _ZonaId = value; }
        }

        private decimal _Cuota;
        public decimal Cuota
        {
            get { return _Cuota; }

            set { _Cuota = value; }
        }
    }
}
