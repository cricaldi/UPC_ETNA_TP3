using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;

namespace ETNA.BL.PV
{
    public class GestorInformesReclamo
    {

        public int InsertarInformeReclamo(string codigoInforme, string descripcion,string detalleInforme,DateTime fechaAprobacion,DateTime fechaElaboracion,
            string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId)
    {
            var context = new INTEGRADOModelContainer();
            var newInforme = new TB_PV_InformesReclamo();
            try
            {

                newInforme.CodigoInforme = "IR" + DateTime.Now.Year.ToString("0000") + newInforme.InformeReclamoId.ToString("00000");
                newInforme.FechaElaboracion = DateTime.Now;
                newInforme.Descripcion = descripcion;
                newInforme.DetalleInforme = detalleInforme;
                newInforme.ObservacionAprobador = null;//observacionAprobador;
                newInforme.FechaAprobacion = null;// DateTime.Now.AddDays(5);
                newInforme.Estado = "E";
                newInforme.TB_RH_Empleados1 = context.TB_RH_Empleados.Find(1);
                newInforme.ElaboradoPorId = newInforme.TB_RH_Empleados1.EmpleadoId;
                newInforme.TB_RH_Empleados = null; //context.TB_RH_Empleados.Find(1);
                newInforme.AprobadoPorId = null;// newInforme.TB_RH_Empleados1.EmpleadoId;
                newInforme.ReclamoId = reclamoId;
             
                context.TB_PV_InformesReclamo.Add(newInforme);
                context.SaveChanges();
                var informe = context.TB_PV_InformesReclamo.Find(newInforme.InformeReclamoId);
                informe.CodigoInforme = "IR" + DateTime.Now.Year.ToString("0000") + newInforme.InformeReclamoId.ToString("00000");
                context.SaveChanges();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return newInforme.InformeReclamoId;
        }

        public bool EditarInformeReclamo(int idInforme, string codigoInforme, string descripcion, string detalleInforme, DateTime fechaAprobacion, DateTime fechaElaboracion,
            string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId)
        {
            var context = new INTEGRADOModelContainer();

            var informe = context.TB_PV_InformesReclamo.Find(idInforme);
            try
            {
                informe.Descripcion = descripcion;
                informe.DetalleInforme = detalleInforme;
            //    informe.Estado = estado;
                
                context.SaveChanges();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }

        public List<TB_PV_InformesReclamo> Listar()
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_InformesReclamo.ToList();
        }

        public TB_PV_InformesReclamo ObtenerInformeReclamo(int idInforme)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_InformesReclamo.Find(idInforme);
        }

 
    }
}
