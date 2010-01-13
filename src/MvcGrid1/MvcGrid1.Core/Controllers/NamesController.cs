using System.Web.Mvc;
using MvcGrid1.Core.Lib.Data;
using MvcGrid1.Core.Models;

namespace MvcGrid1.Core.Controllers
{
    public class NamesController : ApplicationController
    {
        private readonly IRepository _repository;

        public NamesController(IRepository repository)
        {
            _repository = repository;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Name form)
        {
            _repository.Insert(form);
            _repository.Commit();
            if (Request.IsAjaxRequest())
            {
                return PartialView("ListPartial", form);
            }
            return RedirectToAction("Index");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(int id)
        {
            var name = _repository.FindSingle<Name>(n => n.Id == id);
            if (Request.IsAjaxRequest())
            {
                return PartialView("ListPartial", name);
            }
            return View("Details", name);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Edit(int id)
        {
            var name = _repository.FindSingle<Name>(n => n.Id == id);
            if (Request.IsAjaxRequest())
            {
                return PartialView("EditPartial", name);
            }
            return View(name);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            var names = _repository.FindAll<Name>();
            return View("List", names);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult New()
        {
            var name = new Name();
            if (Request.IsAjaxRequest())
            {
                return PartialView("NewPartial", name);
            }
            return View(name);
        }

        [AcceptVerbs(HttpVerbs.Put|HttpVerbs.Post)]
        public ActionResult Update(Name form)
        {
            var original = _repository.FindSingle<Name>(n => n.Id == form.Id);
            original.First = form.First ?? string.Empty;
            original.Last = form.Last ?? string.Empty;
            _repository.Commit();
            if (Request.IsAjaxRequest())
            {
                return PartialView("ListPartial", original);
            }
            return RedirectToAction("Index");
        }
    }
}
