using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ETNA.BL.PV;
using ETNA.Common;
using ETNA.DTOs.PV;

namespace ETNA.WCF.PV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Programacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Programacion.svc o Programacion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Programacion : IProgramacion
    {
        public void DoWork()
        {
        }

        public int InsertarProgramacion(string codigoProgramacion, string periodicidad, DateTime fechaInicio,
            DateTime fechaFin, double porcentajeEncuestados, string descripcion, string estado, short diasVigencia,
            int plantillaId)


        {
            var gestorPrograma = new GestorProgramaciones();
            return gestorPrograma.InsertarProgramacion(codigoProgramacion, periodicidad, fechaInicio, fechaFin,
                porcentajeEncuestados, descripcion, estado, diasVigencia, plantillaId);
        }


        public bool EditarProgramacion(int idPrograma, string codigoProgramacion, string periodicidad, DateTime fechaInicio, 
            DateTime fechaFin, double porcentajeEncuestados, string descripcion, string estado, short diasVigencia, 
            int plantillaId)
        {
         
            var gestorPrograma = new GestorProgramaciones();
            return gestorPrograma.EditarProgramacion(idPrograma, codigoProgramacion, periodicidad, fechaInicio, fechaFin,
                porcentajeEncuestados, descripcion, estado, diasVigencia, plantillaId);
        }

        public List<ProgramacionDto> ListaProgramaciones()
        {
            var gestorPrograma = new GestorProgramaciones();
            var lista = gestorPrograma.Listar();
            var listaDtos = new List<ProgramacionDto>();

            foreach (var programa in lista)
            {
                var dto = new ProgramacionDto();
                dto.Id = programa.ProgramacionId;
                dto.CodigoProgramacion = programa.CodigoProgramacion;
                dto.Descripcion = programa.Descripcion;
                dto.Periodicidad = programa.Periodicidad;
                dto.FechaInicio = programa.FechaInicio;
                dto.FechaFin = programa.FechaFin;
                dto.NombrePlantilla = programa.TB_PV_Plantillas.Descripcion;
                dto.PorcentajeEncuestados = programa.PorcentajeEncuestados;
                dto.DiasVigencia = programa.DiasVigencia;
                dto.Estado = programa.Estado;

                if (programa.Estado.Equals("I"))
                {
                    dto.DescripcionEstado = "Inactivo";
                }
                else if (programa.Estado.Equals("A"))
                {
                    dto.DescripcionEstado = "Activo";
                }
                else { dto.DescripcionEstado = "En Ejecución"; }

                if (programa.Periodicidad.Equals("D"))
                {
                    dto.DescripcionPeriodicidad = "Diario";
                }
                else if (programa.Periodicidad.Equals("S"))
                {
                    dto.DescripcionPeriodicidad = "Semanal";
                }
                else { dto.DescripcionPeriodicidad = "Mensual"; }

                listaDtos.Add(dto);
            }

            return listaDtos;
        }


        public ProgramacionDto ObtenerProgramacion(int idPrograma)
        {
            var gestorPrograma = new GestorProgramaciones();
            var programa = gestorPrograma.ObtenerProgramacion(idPrograma);
            var dto = new ProgramacionDto();
            dto.Id = programa.ProgramacionId;
            dto.CodigoProgramacion = programa.CodigoProgramacion;
            dto.Descripcion = programa.Descripcion;
            dto.Periodicidad = programa.Periodicidad;
            dto.FechaInicio = programa.FechaInicio;
            dto.FechaFin = programa.FechaFin;
            dto.PlantillaId = programa.TB_PV_Plantillas.PlantillaId;
            dto.NombrePlantilla = programa.TB_PV_Plantillas.Descripcion;
            dto.PorcentajeEncuestados = programa.PorcentajeEncuestados;
            dto.DiasVigencia = programa.DiasVigencia;
            dto.Estado = programa.Estado;
            if (programa.Estado.Equals("I"))
            {
                dto.DescripcionEstado = "Inactivo";
            }
            else if (programa.Estado.Equals("A"))
            {
                dto.DescripcionEstado = "Activo";
            }
            else { dto.DescripcionEstado = "En Ejecución"; }

            if (programa.Periodicidad.Equals("D"))
            {
                dto.DescripcionPeriodicidad = "Diario";
            }
            else if (programa.Periodicidad.Equals("S"))
            {
                dto.DescripcionPeriodicidad = "Semanal";
            }
            else { dto.DescripcionPeriodicidad = "Mensual"; }


            return dto;
        }





    }
}
