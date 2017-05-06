using Liquid.Library.Domain;
using System;
using System.Web.Mvc;

namespace Liquid.Library.UI.Controllers
{
    public class EntityController<TEntity> : Controller
        where TEntity : Entity
    {
        [HttpGet]
        public ActionResult Index()
        {
            return GetView();
        }

        [HttpGet]
        public ActionResult Overview(Guid? id)
        {
            return GetView("View");
        }

        [HttpGet]
        public ActionResult CreateNew()
        {
            return GetView("CreateNew");
        }

        [HttpGet]
        public ActionResult Update(Guid? id)
        {
            return GetView("Update");
        }

        [HttpGet]
        public ActionResult Delete(Guid? id)
        {
            return GetView("Delete");
        }

        public ActionResult GetView()
        {
            ViewBag.Type = typeof(TEntity).Name;
            return View();
        }

        public ActionResult GetView(string action)
        {
            ViewBag.Type = typeof(TEntity).Name;
            ViewBag.Action = ViewBag.Type.ToLower();
            ViewBag.Action += action;
            return View();
        }
    }
}