using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ETNA.DTOs.PV;
namespace ETNA.WCF.PV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IInformesReclamos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IInformesReclamos
    {
        [OperationContract]
        int InsertarInformeReclamo(string codigoInforme, string descripcion, string detalleInforme, DateTime fechaAprobacion, DateTime fechaElaboracion,
            string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId);
        
        [OperationContract]
        bool EditarInformeReclamo(int idInforme, string codigoInforme, string descripcion, string detalleInforme,
            DateTime fechaAprobacion, DateTime fechaElaboracion,
            string observacionAprobador, string estado, int reclamoId, int elboradoPorId, int aprobadoPorId);
     
        [OperationContract]
        List<InformeReclamoDto> ListaInfomesReclamos();


        [OperationContract]
        InformeReclamoDto ObtenerInformeReclamo(int idInforme);
    }
}
