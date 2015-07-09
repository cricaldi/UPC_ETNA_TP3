using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;
//using ETNA.Domain;

namespace ETNA.BL.PV
{
    public class GestorProgramaciones
    {
        public List<TB_PV_Programaciones> Listar()
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_Programaciones.ToList();
        }

        public int InsertarProgramacion(string codigoProgramacion, string periodicidad, DateTime fechaInicio, DateTime fechaFin, double porcentajeEncuestados, string descripcion, string estado, short diasVigencia, int plantillaId)
        {
            var context = new INTEGRADOModelContainer();
            var objProgramacion = new TB_PV_Programaciones();
            objProgramacion.CodigoProgramacion = "PE" + DateTime.Now.Year.ToString("0000") + objProgramacion.ProgramacionId.ToString("00000");
            objProgramacion.Periodicidad = periodicidad;
            objProgramacion.FechaInicio = fechaInicio;
            objProgramacion.FechaFin = fechaFin;
            objProgramacion.PorcentajeEncuestados = porcentajeEncuestados;
            objProgramacion.Descripcion = descripcion;
            objProgramacion.Estado = "A";
            objProgramacion.DiasVigencia = diasVigencia;
            objProgramacion.TB_PV_Plantillas = context.TB_PV_Plantillas.Find(plantillaId);
            objProgramacion.PlantillaId = objProgramacion.TB_PV_Plantillas.PlantillaId;

            context.TB_PV_Programaciones.Add(objProgramacion);
            context.SaveChanges();
            var programa = context.TB_PV_Programaciones.Find(objProgramacion.ProgramacionId);
            programa.CodigoProgramacion = "PE" + DateTime.Now.Year.ToString("0000") + objProgramacion.ProgramacionId.ToString("00000");
            context.SaveChanges();
            return objProgramacion.ProgramacionId;
        }

        public bool EditarProgramacion(int idPrograma, string codigoProgramacion, string periodicidad, DateTime fechaInicio, DateTime fechaFin, double porcentajeEncuestados, string descripcion, string estado,short diasVigencia,int plantillaId)
        {
            var context = new INTEGRADOModelContainer();
            var programa = context.TB_PV_Programaciones.Find(idPrograma);
          //  if (programa.Estado.Equals("I"))
          //  {
                programa.Periodicidad = periodicidad;
                programa.FechaInicio = fechaInicio;
                programa.FechaFin = fechaFin;
                programa.PorcentajeEncuestados = porcentajeEncuestados;
                programa.Descripcion = descripcion;
                programa.DiasVigencia = diasVigencia;
                programa.Estado = estado;
                programa.TB_PV_Plantillas = context.TB_PV_Plantillas.Find(plantillaId);
                programa.PlantillaId = programa.TB_PV_Plantillas.PlantillaId;

                context.SaveChanges();

                return true;
          //  }
          //  else
          
            //{
              //  return false;
           // }
        }

        public TB_PV_Programaciones ObtenerProgramacion(int idProgramacion)
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_Programaciones.Find(idProgramacion);
        }
    }
}
