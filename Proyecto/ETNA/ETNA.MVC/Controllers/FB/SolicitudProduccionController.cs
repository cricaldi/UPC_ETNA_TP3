using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ETNA.MVC.FabricacionServices;
using ETNA.MVC.Models.FB;
namespace ETNA.MVC.Controllers.FB
{
    public class SolicitudProduccionController : Controller
    {
        //
        // GET: /SolicitudProduccion/

        public ActionResult Index()
        {
            var service = new FabricacionServices.FabricacionServiceClient();
            List<TB_PR_SolicitudProduccion> listadoSolicitud = service.TB_PR_SolicitudProduccion_Listar("1").ToList();

            Mapper.CreateMap<TB_PR_SolicitudProduccion, SolicitudProduccionViewModel>();
            var model = Mapper.Map<List<SolicitudProduccionViewModel>>(listadoSolicitud);

            return View(model);
        }

    }
}
