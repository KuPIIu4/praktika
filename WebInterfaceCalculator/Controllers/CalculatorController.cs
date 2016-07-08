using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calc_IVT_152_DB.TwoArgsCalculator;

namespace WebInterfaceCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        private SelectListItem[] operations = 
            {
                new SelectListItem { Text = "Сложение", Value = "buttonAdd", Selected = true },
                new SelectListItem { Text = "Вычитание", Value = "buttonSub" },
                new SelectListItem { Text = "Умножение", Value = "buttonMult" },
                new SelectListItem { Text = "Деление", Value = "buttonDiv" },
                new SelectListItem { Text = "Степень", Value = "buttonExp"},
                new SelectListItem { Text = "Корень", Value = "buttonRoot" },
                new SelectListItem { Text = "Логарифм", Value = "buttonLog" }
            };
        // GET: Calculator
        public ActionResult Index()
        {
            ViewBag.Operations = operations;
            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstValue, double secondValue, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            ViewBag.Result = calculator.Calculate(firstValue, secondValue);
            ViewBag.Operations = operations;
            return View();
        }
    }
}