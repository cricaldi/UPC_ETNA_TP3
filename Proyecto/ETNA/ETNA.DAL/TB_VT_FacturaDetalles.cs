//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETNA.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_VT_FacturaDetalles
    {
        public TB_VT_FacturaDetalles()
        {
            this.TB_PV_Reclamos = new HashSet<TB_PV_Reclamos>();
        }
    
        public int FacturaDetalleId { get; set; }
        public int FacturaId { get; set; }
        public Nullable<int> ProductoId { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Valortotal { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> CodigoReq { get; set; }
    
        public virtual TB_AL_Productos TB_AL_Productos { get; set; }
        public virtual ICollection<TB_PV_Reclamos> TB_PV_Reclamos { get; set; }
        public virtual TB_VT_Facturas TB_VT_Facturas { get; set; }
    }
}
