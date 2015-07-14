using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.Domain.Venta
{
    public class PedidoDetalleBE
    {

        private Int32 _IdDetallePedido;
        public Int32 IdDetallePedido
        {
            get { return _IdDetallePedido; }

            set { _IdDetallePedido = value; }
        }

        private Int32 _idproducto;
        public Int32 idproducto
        {
            get { return _idproducto; }

            set { _idproducto = value; }
        }

        private decimal _cantidad;
        public decimal cantidad
        {
            get { return _cantidad; }

            set { _cantidad = value; }
        }

        private decimal _total;
        public decimal total
        {
            get { return _total; }

            set { _total = value; }
        }

        private string _observacion;
        public string observacion
        {
            get { return _observacion; }

            set { _observacion = value; }
        }

        private Int32 _IdPedido;
        public Int32 IdPedido
        {
            get { return _IdPedido; }

            set { _IdPedido = value; }
        }

    }

}
