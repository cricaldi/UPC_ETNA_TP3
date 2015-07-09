using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ETNA.BL.PV;
using ETNA.Domain;
using ETNA.DTOs.PV;
namespace ETNA.WCF.PV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "InformesReclamos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione InformesReclamos.svc o InformesReclamos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class InformesReclamos : IInformesReclamos
    {
        public int InsertarInformeReclamo(string codigoInforme, string descripcion, string detalleInforme, DateTime fechaAprobacion, DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId)
        {
            var gestorInformesReclamos = new GestorInformesReclamo();
            return gestorInformesReclamos.InsertarInformeReclamo(codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, elboradoPorId, aprobadoPorId);
        }


        public bool EditarInformeReclamo(int idInforme, string codigoInforme, string descripcion, string detalleInforme, DateTime fechaAprobacion, DateTime fechaElaboracion, string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId)
        {
            var gestorInformesReclamos = new GestorInformesReclamo();
            return gestorInformesReclamos.EditarInformeReclamo(idInforme, codigoInforme, descripcion, detalleInforme, fechaAprobacion, fechaElaboracion, observacionAprobador, estado, reclamoId, elboradoPorId, aprobadoPorId);
        }


        public List<InformeReclamoDto> ListaInfomesReclamos()
        {
            var gestorInformeReclamo = new GestorInformesReclamo();
            var lista = gestorInformeReclamo.Listar();
            var listaDtos = new List<InformeReclamoDto>();

            foreach (var informe in lista)
            {
                var dto = new InformeReclamoDto();
                dto.InformeReclamoId = informe.InformeReclamoId;
                dto.CodigoInforme = informe.CodigoInforme;
                dto.DetalleInforme = informe.DetalleInforme;
                dto.Descripcion = informe.Descripcion;
                dto.ObservacionAprobador = informe.ObservacionAprobador;
                dto.FechaElaboracion = informe.FechaElaboracion;
                dto.FechaAprobacion =  informe.FechaAprobacion;

                //             dto.NombreRegistrador = reclamo.RegistradoPorId.Nombres + " " + reclamo.RegistradoPorId.Apellidos;
                dto.NombreElaborador = informe.TB_RH_Empleados1.Nombres.Trim() + " " + informe.TB_RH_Empleados1.Apellidos.Trim();
                dto.ElaboradoPorId = informe.TB_RH_Empleados1.EmpleadoId;

                if (informe.TB_RH_Empleados!=null) {
                dto.NombreAprobador = informe.TB_RH_Empleados.Nombres.Trim() + " " + informe.TB_RH_Empleados.Apellidos.Trim();
                dto.AprobadoPorId = informe.TB_RH_Empleados.EmpleadoId;
                }
                
                dto.Estado = informe.Estado;
                dto.ReclamoId = informe.ReclamoId;
                dto.CodigoReclamo = informe.TB_PV_Reclamos.CodigoReclamo;

                if (informe.Estado.Equals("E"))
                {
                    dto.DescripcionEstado = "Elaborado";
                }
                else if (informe.Estado.Equals("A"))
                {
                    dto.DescripcionEstado = "Aprobado";
                }
                else { dto.DescripcionEstado = "Rechazado"; }

                listaDtos.Add(dto);
            }

            return listaDtos;
        }


        
        public InformeReclamoDto ObtenerInformeReclamo(int idInforme)
        {
            var gestorInformeReclamo = new GestorInformesReclamo();
            var informe = gestorInformeReclamo.ObtenerInformeReclamo(idInforme);
            var dto = new InformeReclamoDto();
            if (informe != null)
            {
                dto.InformeReclamoId = informe.InformeReclamoId;
                dto.CodigoInforme = informe.CodigoInforme;
                dto.DetalleInforme = informe.DetalleInforme;
                dto.Descripcion = informe.Descripcion;
                dto.ObservacionAprobador = informe.ObservacionAprobador;
                dto.FechaElaboracion = informe.FechaElaboracion;
                dto.FechaAprobacion = informe.FechaAprobacion;

                //             dto.NombreRegistrador = reclamo.RegistradoPorId.Nombres + " " + reclamo.RegistradoPorId.Apellidos;
                dto.NombreElaborador = informe.TB_RH_Empleados1.Nombres.Trim() + " " +
                                       informe.TB_RH_Empleados1.Apellidos.Trim();
                dto.ElaboradoPorId = informe.TB_RH_Empleados1.EmpleadoId;
                 
                if (informe.TB_RH_Empleados != null)
                {
                    dto.NombreAprobador = informe.TB_RH_Empleados.Nombres.Trim() + " " +
                                          informe.TB_RH_Empleados.Apellidos.Trim();
                    dto.AprobadoPorId = informe.TB_RH_Empleados.EmpleadoId;
                }

                dto.Estado = informe.Estado;
                dto.ReclamoId = informe.ReclamoId;
                dto.CodigoReclamo = informe.TB_PV_Reclamos.CodigoReclamo;

                if (informe.Estado.Equals("E"))
                {
                    dto.DescripcionEstado = "Elaborado";
                }
                else if (informe.Estado.Equals("A"))
                {
                    dto.DescripcionEstado = "Aprobado";
                }
                else
                {
                    dto.DescripcionEstado = "Rechazado";
                }
            }

            return dto;

        }

    }
}
