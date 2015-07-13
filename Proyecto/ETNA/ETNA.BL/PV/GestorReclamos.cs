using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ETNA.DAL;
using ETNA.Domain;
using ETNA.Common;


namespace ETNA.BL.PV
{
    public class GestorReclamos
    {
        public static int TamanoPaginas = 5;

        public int InsertarReclamo(string codigoReclamo, DateTime fechaHoraReclamo, string motivo,
            string detalle, string observaciones, DateTime fechaRespuesta, string estado, int idFacturaDetalle,int idUsuario)
        {
            var context = new INTEGRADOModelContainer();
            var newReclamo = new TB_PV_Reclamos();
            try
            {
           
            newReclamo.CodigoReclamo = "RE"+DateTime.Now.Year.ToString("0000")+newReclamo.ReclamoId.ToString("00000");
            newReclamo.FechaHoraReclamo = DateTime.Now;
            newReclamo.Motivo = motivo;
            newReclamo.Detalle = detalle;
            newReclamo.Observaciones = observaciones;
            newReclamo.FechaRespuesta = null;
            newReclamo.Estado = "P";
            newReclamo.TB_RH_Empleados= context.TB_RH_Empleados.Find(idUsuario);
                newReclamo.RegistradoPorId = newReclamo.TB_RH_Empleados.EmpleadoId;
            newReclamo.TB_VT_FacturaDetalles = context.TB_VT_FacturaDetalles.Find(idFacturaDetalle);
                newReclamo.FacturaDetalleId = newReclamo.TB_VT_FacturaDetalles.FacturaDetalleId;

            context.TB_PV_Reclamos.Add(newReclamo);
            context.SaveChanges();
            var reclamo = context.TB_PV_Reclamos.Find(newReclamo.ReclamoId);
            reclamo.CodigoReclamo = "RE" + DateTime.Now.Year.ToString("0000") + newReclamo.ReclamoId.ToString("00000");
            context.SaveChanges();
             }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return newReclamo.ReclamoId;
        }

        public bool EditarReclamo(int idReclamo, string codigoReclamo, DateTime fechaHoraReclamo, string motivo,
            string detalle, string observaciones, DateTime fechaRespuesta, string estado,int idFacturaDetalle)
        {
            var context = new INTEGRADOModelContainer();
       
             var reclamo = context.TB_PV_Reclamos.Find(idReclamo);
             try
             {
            reclamo.Motivo = motivo;
            reclamo.Detalle = detalle;
            reclamo.Observaciones = observaciones;
            reclamo.Estado = estado;
            reclamo.TB_VT_FacturaDetalles = context.TB_VT_FacturaDetalles.Find(idFacturaDetalle);
            reclamo.FacturaDetalleId = reclamo.TB_VT_FacturaDetalles.FacturaDetalleId;
            context.SaveChanges();
             }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }
        public bool ActualizarEstadoReclamo(int idReclamo, string estado)
        {
            var context = new INTEGRADOModelContainer();

            var reclamo = context.TB_PV_Reclamos.Find(idReclamo);
            try
            {
                reclamo.Estado = estado;
                if (estado == "R" || estado == "A")
                {
                    reclamo.FechaRespuesta = DateTime.Now;

                }
                context.SaveChanges();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }


        public List<TB_PV_Reclamos> Listar()
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_Reclamos.ToList();
        }

        public List<TB_PV_Reclamos> ListarPorEstado(String estado)
        {
            var context = new INTEGRADOModelContainer();
            
            return context.TB_PV_Reclamos.Where(d => d.Estado==estado).ToList();
        }

        public TB_PV_Reclamos ObtenerReclamo(int idReclamo)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_Reclamos.Find(idReclamo);
        }

        public List<int> NroPaginasPorCodigoReclamo(string codigoReclamo)
        {
            var context = new INTEGRADOModelContainer();
            var list = new List<int>();

            //var total = context.FacturaDetalles.Where(d => d.Factura.NroFactura.Contains(nroFactura)).ToList().Count;
            // No exite numero de factura sunat en tabla
            var total = context.TB_PV_Reclamos.Where(d => d.CodigoReclamo.Contains(codigoReclamo)).ToList().Count;

            list.Add(total);
            list.Add((total / GestorReclamos.TamanoPaginas) + 1);
            return list;
        }

        public List<TB_PV_Reclamos> ListarReclamosPorCodigo(string codigoReclamo, int nropagina = 1)
        {
            var param1 = new SqlParameter("@num_pagina", (nropagina < 1 ? 1 : nropagina));
            var param2 = new SqlParameter("@tam_pagina", GestorReclamos.TamanoPaginas); //Tamaño de registros 10 by default
            var param3 = new SqlParameter("@cod_reclamo", codigoReclamo);

            var context = new INTEGRADOModelContainer();
            //           var detalleObj = context.Database.SqlQuery<FacturaDetalle>("exec GetPaginasRowNumber @num_pagina, @tam_pagina, @nro_factura", param1, param2, param3).ToList<FacturaDetalle>();
            var detalleObj = context.Database.SqlQuery<TB_PV_Reclamos>("exec GetPaginasRowNumberReclamos @num_pagina, @tam_pagina, @cod_reclamo", param1, param2, param3).ToList<TB_PV_Reclamos>();

            var listaDetalle = new List<TB_PV_Reclamos>();
            foreach (var detalle in detalleObj)
            {
                var reclamo = this.ObtenerReclamo(detalle.ReclamoId);
                listaDetalle.Add(reclamo);
            }
            return listaDetalle;
            //return context.FacturaDetalles.Where(d => d.Factura.NroFactura.Contains(nroFactura)).ToList();
            //(d =>  d.Factura.NroFactura == nroFactura).ToList();
        }
}
}
