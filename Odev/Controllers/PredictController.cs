using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Odev.MLModel;

namespace Odev.Controllers
{
    public class PredictController : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Predict(ModelInput input)
        {
            var prediction = MLModel.Predict(input);
            ViewBag.Result = prediction;
            return View();
        }
        [HttpGet]
        public IActionResult Predict1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Predict1(ModelInput input)
        {
            var prediction = MLModel.Predict(input);
            ViewBag.Result = prediction;
            return View();
        }
    }
}
