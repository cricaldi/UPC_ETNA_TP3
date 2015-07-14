using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class CuentaVentaBE
    {
        private Int32 _CuotaId;
        public Int32 CuotaId
        {
            get { return _CuotaId; }

            set { _CuotaId = value; }
        }

        private Int32 _Mes;
        public Int32 Mes
        {
            get { return _Mes; }

            set { _Mes = value; }
        }

        private Int32 _Año;
        public Int32 Año
        {
            get { return _Año; }

            set { _Año = value; }
        }

        private string _Dias_Habiles;
        public string Dias_Habiles
        {
            get { return _Dias_Habiles; }

            set { _Dias_Habiles = value; }
        }

        private decimal _Monto_Cuota;
        public decimal Monto_Cuota
        {
            get { return _Monto_Cuota; }

            set { _Monto_Cuota = value; }
        }
    }
}
