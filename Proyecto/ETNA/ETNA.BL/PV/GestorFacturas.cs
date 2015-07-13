using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ETNA.DAL;

namespace ETNA.BL.PV
{
    public class GestorFacturas
    {
        public static int TamanoPaginas = 5;

        public List<TB_VT_Facturas> Listar()
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_VT_Facturas.ToList();
        }

        public TB_VT_Facturas ObtenerFactura(int idFactura)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_VT_Facturas.Find(idFactura);
        }

        public List<TB_VT_FacturaDetalles> ListarDetalle(int idFactura)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_VT_FacturaDetalles.Where(d => d.TB_VT_Facturas.FacturaId == idFactura).ToList();
        }

        public List<int> NroPaginasPorDetalleNroFactura(string nroFactura)
        {
            var context = new INTEGRADOModelContainer();
            var list = new List<int>();

            //var total = context.FacturaDetalles.Where(d => d.Factura.NroFactura.Contains(nroFactura)).ToList().Count;
            // No exite numero de factura sunat en tabla
            var total = context.TB_VT_FacturaDetalles.Where(d => d.TB_VT_Facturas.NumeroFact.Contains(nroFactura)).ToList().Count;

            list.Add(total);
            list.Add((total / GestorFacturas.TamanoPaginas) + 1);
            return list;
        }

        public List<TB_VT_FacturaDetalles> ListarDetallePorNroFactura(string nroFactura, int nropagina = 1)
        {
            var param1 = new SqlParameter("@num_pagina", (nropagina<1?1:nropagina));
            var param2 = new SqlParameter("@tam_pagina", GestorFacturas.TamanoPaginas); //Tamaño de registros 10 by default
            var param3 = new SqlParameter("@nro_factura", nroFactura);

            var context = new INTEGRADOModelContainer();
 //           var detalleObj = context.Database.SqlQuery<FacturaDetalle>("exec GetPaginasRowNumber @num_pagina, @tam_pagina, @nro_factura", param1, param2, param3).ToList<FacturaDetalle>();
            var detalleObj = context.Database.SqlQuery<TB_VT_FacturaDetalles>("exec GetPaginasRowNumber @num_pagina, @tam_pagina, @nro_factura", param1, param2, param3).ToList<TB_VT_FacturaDetalles>();

            var listaDetalle = new List<TB_VT_FacturaDetalles>();
            foreach (var detalle in detalleObj)
            {
                var factdeta = this.ObtenerDetalleFactura(detalle.FacturaDetalleId);
                listaDetalle.Add(factdeta);
            }
            return listaDetalle;
            //return context.FacturaDetalles.Where(d => d.Factura.NroFactura.Contains(nroFactura)).ToList();
            //(d =>  d.Factura.NroFactura == nroFactura).ToList();
        }

        public TB_VT_FacturaDetalles ObtenerDetalleFactura(int idDetalle)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_VT_FacturaDetalles.Find(idDetalle);
        }
    }
}
