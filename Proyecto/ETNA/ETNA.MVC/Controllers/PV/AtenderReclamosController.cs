using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ETNA.MVC.FacturasServices;
using ETNA.MVC.InformesReclamosServices;
using ETNA.MVC.PostVentaServices;
using ETNA.MVC.Models.PV;
using AutoMapper;
using WebMatrix.WebData;

namespace ETNA.MVC.Controllers.PV
{
    public class AtenderReclamosController : Controller
    {
        //
        // GET: /Reclamo/

        public ActionResult Index()
        {

            var service = new PostVentaServices.ReclamosClient();
            var dtos = service.ListaReclamosPendientes();

            Mapper.CreateMap<ReclamoDto, ReclamoViewModel>();
            var model = Mapper.Map<List<ReclamoViewModel>>(dtos);


            return View(model);

        }

        //
        // GET: /Reclamo/Details/5

        public ActionResult Details(int id)
        {
            @ViewBag.Id = id;


            //Invocamos al servicio
            var service = new PostVentaServices.ReclamosClient();

            //Como código de empleado le pasamos el current user id (es importante que coincida con el empleado id)
            var reclamosDto = service.ObtenerReclamo(id);

            //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
            var model = Mapper.Map<ReclamoViewModel>(reclamosDto);

            return View(model);
        }

        //
        // GET: /Reclamo/Create

        public ActionResult Create()
        {


            return View();
        }

        //
        // POST: /Reclamo/Create

        [HttpPost]
        public ActionResult Create(ReclamoViewModel model)
        {
            try
            {
                //var service = new PostVentaServices.ReclamosClient();
                //service.InsertarReclamo(model.CodigoReclamo, model.FechaHoraReclamo, model.Motivo, model.Detalle, model.Observaciones, model.FechaRespuesta, model.Estado, model.IdFacturaDetalle);


                return RedirectToAction("Index", new { creado = true });


            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return View(model);
            }

        }

        //
        // GET: /Reclamo/Edit/5
        // GET: /InformeReclamo/Create
       
        public ActionResult Atender(int id)
        {
            var service = new PostVentaServices.ReclamosClient();

            //Como código de empleado le pasamos el current user id (es importante que coincida con el empleado id)
            var reclamosDto = service.ObtenerReclamo(id);

            //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
  

            //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
            var model = new InformeReclamoViewModel();
            model.CodigoReclamo = reclamosDto.CodigoReclamo;
            model.NombreCliente = reclamosDto.NombreCliente;
            model.FechaHoraReclamo = reclamosDto.FechaHoraReclamo;
            model.ReclamoId = id;
        
   
            return View(model);

        }

        //
        // POST: /InformeReclamo/Create

        [HttpPost]
        public ActionResult Atender(InformeReclamoViewModel model1)
        {
            try
            {
                var service = new InformesReclamosServices.InformesReclamosClient();
                service.InsertarInformeReclamo(model1.CodigoInforme, model1.Descripcion, model1.DetalleInforme, model1.FechaAprobacion, model1.FechaElaboracion, model1.ObservacionAprobador, model1.Estado, model1.ReclamoId, WebSecurity.CurrentUserId, model1.AprobadoPorId);


                return RedirectToAction("Index", new { creado = true });

            }
            catch
            {
                return View();
            }
        }


    }
}
