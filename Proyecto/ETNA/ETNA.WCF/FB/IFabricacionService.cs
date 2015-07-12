using ETNA.Domain;
using ETNA.DTOs.FB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ETNA.WCF.FB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFabricacionService" in both code and config file together.
    [ServiceContract]
    public interface IFabricacionService
    {

        #region "Solicitud Produccion"

        [OperationContract]
        List<TB_PR_SolicitudProduccion> TB_PR_SolicitudProduccion_Listar(string pCOD_ESTADO);

        #endregion

        #region "Lotes"

        [OperationContract]
        int InsertarLote(string nroLote, int idTipoLote);

        [OperationContract]
        bool EditarLote(int idLote, string nroLote);

        [OperationContract]
        bool EliminarLote(int idLote);

        [OperationContract]
        List<LoteDto> ListaLotes();

        #endregion

    }
}
