using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class EmpleadosBE
    {

        private Int32 _Id;
        public Int32 Id
        {
            get { return _Id; }

            set { _Id = value; }
        }



        private Int32 _codmodalidad;
        public Int32 codmodalidad
        {
            get { return _codmodalidad; }

            set { _codmodalidad = value; }
        }


        private string _Nombres;
        public string Nombres
        {
            get { return  _Nombres.Trim(); }

            set { _Nombres = value; }
        }

        private string _Apellidos;
        public string Apellidos
        {
            get { return _Apellidos.Trim(); }

            set { _Apellidos = value; }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }

            set { _Direccion = value; }
        }

        private string _Cargo;
        public string Cargo
        {
            get { return _Cargo; }

            set { _Cargo = value; }
        }

        private Int32 _UserProfile_UserId;
        public Int32 UserProfile_UserId
        {
            get { return _UserProfile_UserId; }

            set { _UserProfile_UserId = value; }
        }

        private Int32 _IDGrupoVentas;
        public Int32 IDGrupoVentas
        {
            get { return _IDGrupoVentas; }

            set { _IDGrupoVentas = value; }
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

    }
}
