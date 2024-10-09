using BinaryString.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryString.Controllers
{
    public class BinaryController : Controller
    {
        [HttpGet]
        public ActionResult Homepage()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CheckBinaryString(BinaryValidator model)
        {
            if (ModelState.IsValid)
            {
                model.IsGood = model.CheckIfGood();
                return Json(new { IsGood = model.IsGood });
            }

            return Json(new { IsGood = false });
        }

    }
}