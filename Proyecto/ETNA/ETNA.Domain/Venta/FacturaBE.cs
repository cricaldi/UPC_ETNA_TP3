using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class FacturaBE
    {
        private Int32 _FacturaId;
        public Int32 FacturaId
        {
            get { return _FacturaId; }

            set { _FacturaId = value; }
        }


        private Int32 _TipoCP;
        public Int32 TipoCP
        {
            get { return _TipoCP; }

            set { _TipoCP = value; }
        }

        private Int32 _NumeroFact;
        public Int32 NumeroFact
        {
            get { return _NumeroFact; }

            set { _NumeroFact = value; }
        }

        private Int32 _ClienteId;
        public Int32 ClienteId
        {
            get { return _ClienteId; }

            set { _ClienteId = value; }
        }

        private DateTime _FechaEmision;
        public DateTime FechaEmision
        {
            get { return _FechaEmision; }

            set { _FechaEmision = value; }
        }

        private DateTime _FechaEntrega;
        public DateTime FechaEntrega
        {
            get { return _FechaEntrega; }

            set { _FechaEntrega = value; }
        }

        private Int32 _ModalidadCreditoId;
        public Int32 ModalidadCreditoId
        {
            get { return _ModalidadCreditoId; }

            set { _ModalidadCreditoId = value; }
        }

        private DateTime _FechaPago;
        public DateTime FechaPago
        {
            get { return _FechaPago; }

            set { _FechaPago = value; }
        }

        private bool _Credito;
        public bool Credito
        {
            get { return _Credito; }

            set { _Credito = value; }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }

            set { _Direccion = value; }
        }

        private Int32 _IdVendedor;
        public Int32 IdVendedor
        {
            get { return _IdVendedor; }

            set { _IdVendedor = value; }
        }

        private string _Observacion;
        public string Observacion
        {
            get { return _Observacion; }

            set { _Observacion = value; }
        }

        private double _ValorVenta;
        public double ValorVenta
        {
            get { return _ValorVenta; }

            set { _ValorVenta = value; }
        }

        private bool _PrecioIncluyeImpuesto;
        public bool PrecioIncluyeImpuesto
        {
            get { return _PrecioIncluyeImpuesto; }

            set { _PrecioIncluyeImpuesto = value; }
        }

        private string _EstadoFacturacion;
        public string EstadoFacturacion
        {
            get { return _EstadoFacturacion; }

            set { _EstadoFacturacion = value; }
        }

        private string _DireccionEntrega;
        public string DireccionEntrega
        {
            get { return _DireccionEntrega; }

            set { _DireccionEntrega = value; }
        }

        private decimal _Subtotal;
        public decimal Subtotal
        {
            get { return _Subtotal; }

            set { _Subtotal = value; }
        }

        private decimal _MontoIGV;
        public decimal MontoIGV
        {
            get { return _MontoIGV; }

            set { _MontoIGV = value; }
        }

        private decimal _Total;
        public decimal Total
        {
            get { return _Total; }

            set { _Total = value; }
        }

        private string _Observaciones;
        public string Observaciones
        {
            get { return _Observaciones; }

            set { _Observaciones = value; }
        }

        private DateTime _FechaRegistro;
        public DateTime FechaRegistro
        {
            get { return _FechaRegistro; }

            set { _FechaRegistro = value; }
        }

        private DateTime _FechaVencimiento;
        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }

            set { _FechaVencimiento = value; }
        }

        private Int32 _CodigoSolAtencion;
        public Int32 CodigoSolAtencion
        {
            get { return _CodigoSolAtencion; }

            set { _CodigoSolAtencion = value; }
        }

        private Int32 _CodigoReq;
        public Int32 CodigoReq
        {
            get { return _CodigoReq; }

            set { _CodigoReq = value; }
        }

        private Int32 _CodigoFormato;
        public Int32 CodigoFormato
        {
            get { return _CodigoFormato; }

            set { _CodigoFormato = value; }
        }
    }
}
