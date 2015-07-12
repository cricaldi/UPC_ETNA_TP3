using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using ETNA.MVC.FabricacionServices;
using ETNA.MVC.Models.FB;

namespace ETNA.MVC.Controllers.FB
{
    public class LoteController : Controller
    {
        //
        // GET: /Lote/

        public ActionResult Index(bool? creado)
        {
            var service = new FabricacionServices.FabricacionServiceClient();
            var dtos = service.ListaLotes();

            Mapper.CreateMap<LoteDto, LoteViewModel>();
            var model = Mapper.Map<List<LoteViewModel>>(dtos);

            if (creado.HasValue && creado.GetValueOrDefault())
                ViewBag.MensajeConfirmacion = "El lote se insertó correctamente";

            return View(model);
        }

        //
        // GET: /Lote/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Lote/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Lote/Create

        [HttpPost]
        public ActionResult Create(LoteViewModel model)
        {
            try
            {
                var service = new FabricacionServices.FabricacionServiceClient();
                service.InsertarLote(model.NroLote, 1);
                return RedirectToAction("Index", new {creado = true});
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Lote/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Lote/Edit/5

        [HttpPost]
        public ActionResult Edit(LoteViewModel model)
        {
            try
            {
                var service = new FabricacionServices.FabricacionServiceClient();
                service.EditarLote(model.Id, model.NroLote);
                return Index(true);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Lote/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Lote/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
