using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMC_Web_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index(string num1, string num2, string result)
        {
            return View((num1, num2, result));
        }

        [HttpPost]
        public IActionResult DoMath(string firstNum, string secondNum, string operation)
        {
            // if can't parse either num to double, return a message about this as result
            if (!double.TryParse(firstNum, out double num1) | !double.TryParse(secondNum, out double num2))
            {
                return RedirectToAction("Index", "Home", 
                    routeValues: new { num1 = firstNum, num2 = secondNum, result = "This won\'t do *disappointed*" });
            }

            string result;
            switch (operation)
            {
                case "add":
                    result = (num1 + num2).ToString();
                    break;
                case "sub":
                    result = (num1 - num2).ToString();
                    break;
                case "mul":
                    result = (num1 * num2).ToString();
                    break;
                case "div":
                    result = (num1 / num2).ToString();
                    break;
                case "pow":
                    result = (Math.Pow(num1, num2)).ToString();
                    break;
                default:
                    result = "This won\'t do *disappointed*";
                    break;       
            }
            return RedirectToAction("Index", "Home", routeValues: new { num1 = firstNum, num2 = secondNum, result = result });
        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
