using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class TipoCPBE
    {
        private Int32 _TipoCpId;
        public Int32 TipoCpId
        {
            get { return _TipoCpId; }

            set { _TipoCpId = value; }
        }

        private Int32 _TipoDocIdentidadId;
        public Int32 TipoDocIdentidadId
        {
            get { return _TipoDocIdentidadId; }

            set { _TipoDocIdentidadId = value; }
        }

        private string _Abreviacion;
        public string Abreviacion
        {
            get { return _Abreviacion; }

            set { _Abreviacion = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }

            set { _Descripcion = value; }
        }

        private string _Serie;
        public string Serie
        {
            get { return _Serie; }

            set { _Serie = value; }
        }

        private Int32 _LongitudSerie;
        public Int32 LongitudSerie
        {
            get { return _LongitudSerie; }

            set { _LongitudSerie = value; }
        }

        private Int32 _Numero;
        public Int32 Numero
        {
            get { return _Numero; }

            set { _Numero = value; }
        }

        private Int32 _LongitudNumero;
        public Int32 LongitudNumero
        {
            get { return _LongitudNumero; }

            set { _LongitudNumero = value; }
        }

        private bool _NumeracionAutomatica;
        public bool NumeracionAutomatica
        {
            get { return _NumeracionAutomatica; }

            set { _NumeracionAutomatica = value; }
        }


          private string _NumeroSerie;
        public string NumeroSerie
        {
            get { return _NumeroSerie; }

            set { _NumeroSerie = value; }
        }
 
    }
}
