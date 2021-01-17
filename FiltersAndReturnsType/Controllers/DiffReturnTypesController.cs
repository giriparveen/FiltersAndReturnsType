using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Controllers
{
    public class DiffReturnTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public ViewResult GetDiffReturnType()
        //{
        //    ViewBag.Type = "ViewResult";
        //    return View();
        //}
        //public IActionResult GetDiffReturnType()
        //{
        //    ViewBag.Type = "IActionResult";
        //    return View();
        //}
        //public RedirectToActionResult GetDiffReturnType()
        //{
        //    ViewBag.Type = "RedirectToActionResult";
        //    return RedirectToAction("index");
        //}
        //public EmptyResult GetDiffReturnType()
        //{
        //    ViewBag.Type = "EmptyResult";
        //    return new EmptyResult();
        //}
        //public ContentResult GetDiffReturnType()
        //{
        //    ViewBag.Type = "ContentResult";
        //    return Content("I am from ContentResult");
        //}
        public JsonResult GetDiffReturnType()
        {
            ViewBag.Type = "JsonResult";
            return Json("Json Result Data");
        }
    }
}
