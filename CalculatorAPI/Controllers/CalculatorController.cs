using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLogic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        //Made use of properties here because it would be repeated through all api cals
        [FromQuery]
        public double number1 { get; set; }

        [FromQuery]
        public double number2 { get; set; }

        [HttpGet]
        public double Addition()
        {
            return Calc.Add(number1, number2);
        }

        [HttpGet]
        public double Subtraction()
        {
            return Calc.Subtract(number1, number2);
        }

        [HttpGet]
        public double Multiplication()
        {
            return Calc.Multiply(number1, number2);
        }

        [HttpGet]
        public double Division()
        { //dividing by 0 returns a long error message but here we just replace it with -1
            if (number2 == 0)
            {
                return -1;
            }

            else
            {
                return Calc.Divide(number1, number2);
            }
        }
    }
}
