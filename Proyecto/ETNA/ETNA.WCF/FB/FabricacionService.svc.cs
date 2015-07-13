using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ETNA.BL.FB;
using ETNA.Domain;
using ETNA.DTOs.FB;
using AutoMapper;

namespace ETNA.WCF.FB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FabricacionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FabricacionService.svc or FabricacionService.svc.cs at the Solution Explorer and start debugging.
    public class FabricacionService : IFabricacionService
    {
        #region "Solicitud Produccion"

        public List<TB_PR_SolicitudProduccion> TB_PR_SolicitudProduccion_Listar(string pCOD_ESTADO)
        {
            return new TB_PR_SolicitudProduccionBL().TB_PR_SolicitudProduccion_Listar(pCOD_ESTADO);
        }

        #endregion

        #region "Lotes"

        public int InsertarLote(string nroLote, int idTipoLote)
        {
            var gestorLotes = new GestorLotes();
            return gestorLotes.InsertarLote(nroLote, idTipoLote);
        }

        public bool EditarLote(int idLote, string nroLote)
        {
            var gestorLotes = new GestorLotes();
            return gestorLotes.EditarLote(idLote, nroLote);
        }

        public bool EliminarLote(int idLote)
        {
            var gestorLotes = new GestorLotes();
            return gestorLotes.EliminarLote(idLote);
        }

        public List<LoteDto> ListaLotes()
        {
            var gestorLotes = new GestorLotes();
            var lista = gestorLotes.Listar();



            Mapper.CreateMap<Lote, LoteDto>()
                .ForMember(dest => dest.DescripcionTipoLote, opts => opts.MapFrom(src => src.TipoLote.Descripcion));
            var listaDtos = Mapper.Map<List<LoteDto>>(lista);

            return listaDtos;
        }

        #endregion
    }
}
