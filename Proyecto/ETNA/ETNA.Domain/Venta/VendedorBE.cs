using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.Domain.Venta
{
   public class VendedorBE
    {
        private Int32 _IdVendedor;
        public Int32 IdVendedor
        {
            get { return _IdVendedor; }

            set { _IdVendedor = value; }
        }

        private Int32 _IDGrupoVentas;
        public Int32 IDGrupoVentas
        {
            get { return _IDGrupoVentas; }

            set { _IDGrupoVentas = value; }
        }

        private bool _Activo;
        public bool Activo
        {
            get { return _Activo; }

            set { _Activo = value; }
        }

        private Int32 _EmpleadoId;
        public Int32 EmpleadoId
        {
            get { return _EmpleadoId; }

            set { _EmpleadoId = value; }
        }

        private decimal _ComisionVenta;
        public decimal ComisionVenta
        {
            get { return _ComisionVenta; }

            set { _ComisionVenta = value; }
        }
    }
}
