using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.Domain.Venta
{
    public class ClienteBE
    {

        private Int32 _IdCliente;
        public Int32 IdCliente
        {
            get { return _IdCliente; }

            set { _IdCliente = value; }
        }

        private Int32 _IDTipoTercero;
        public Int32 IDTipoTercero
        {
            get { return _IDTipoTercero; }

            set { _IDTipoTercero = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }

            set { _Nombre = value; }
        }

        private string _ApellidoPaterno;
        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }

            set { _ApellidoPaterno = value; }
        }

        private string _ApellidoMaterno;
        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }

            set { _ApellidoMaterno = value; }
        }

        private string _PrimerNombre;
        public string PrimerNombre
        {
            get { return _PrimerNombre; }

            set { _PrimerNombre = value; }
        }

        private string _SegundoNombre;
        public string SegundoNombre
        {
            get { return _SegundoNombre; }

            set { _SegundoNombre = value; }
        }

        private string _RazonSocial;
        public string RazonSocial
        {
            get { return _RazonSocial; }

            set { _RazonSocial = value; }
        }

        private Int32 _IDTipoDocIdentidad;
        public Int32 IDTipoDocIdentidad
        {
            get { return _IDTipoDocIdentidad; }

            set { _IDTipoDocIdentidad = value; }
        }

        private Int32 _Ruc;
        public Int32 Ruc
        {
            get { return _Ruc; }

            set { _Ruc = value; }
        }

        private string _DocIdentidad;
        public string DocIdentidad
        {
            get { return _DocIdentidad; }

            set { _DocIdentidad = value; }
        }

        private bool _Activo;
        public bool Activo
        {
            get { return _Activo; }

            set { _Activo = value; }
        }

        private Int32 _IDDireccionPrincipal;
        public Int32 IDDireccionPrincipal
        {
            get { return _IDDireccionPrincipal; }

            set { _IDDireccionPrincipal = value; }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }

            set { _Direccion = value; }
        }

        private decimal _LineaCredito;
        public decimal LineaCredito
        {
            get { return _LineaCredito; }

            set { _LineaCredito = value; }
        }

        private Int32 _IDModalidadCredito;
        public Int32 IDModalidadCredito
        {
            get { return _IDModalidadCredito; }

            set { _IDModalidadCredito = value; }
        }

        private Int32 _DiasCredito;
        public Int32 DiasCredito
        {
            get { return _DiasCredito; }

            set { _DiasCredito = value; }
        }

        private Int32 _IDTipoMedioDePago;
        public Int32 IDTipoMedioDePago
        {
            get { return _IDTipoMedioDePago; }

            set { _IDTipoMedioDePago = value; }
        }

        private bool _CreditoContado;
        public bool CreditoContado
        {
            get { return _CreditoContado; }

            set { _CreditoContado = value; }
        }

        private Int32 _IDCategoriaCliente;
        public Int32 IDCategoriaCliente
        {
            get { return _IDCategoriaCliente; }

            set { _IDCategoriaCliente = value; }
        }

        private bool _LineaCreditoActiva;
        public bool LineaCreditoActiva
        {
            get { return _LineaCreditoActiva; }

            set { _LineaCreditoActiva = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }

            set { _Email = value; }
        }

        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }

            set { _Codigo = value; }
        }

        private string _CodigoPais;
        public string CodigoPais
        {
            get { return _CodigoPais; }

            set { _CodigoPais = value; }
        }

        private Int32 _Telefono;
        public Int32 Telefono
        {
            get { return _Telefono; }

            set { _Telefono = value; }
        }

        private string _Observaciones;
        public string Observaciones
        {
            get { return _Observaciones; }

            set { _Observaciones = value; }
        }

        private string _Usuario;
        public string Usuario
        {
            get { return _Usuario; }

            set { _Usuario = value; }
        }

    }
}
