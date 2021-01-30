using Calculator.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // POST <CalculatorController>/Add
        [HttpPost]
        [Route("Add")]
        public ObjectResult Add(decimal value1, decimal value2)
        {
            decimal returnValue;
            try
            {
                returnValue = Calculations.Add(value1, value2);
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult($"Invalid Request: {e.Message}");
            }
            return new OkObjectResult(returnValue);
        }

        // POST <CalculatorController>/Subtract
        [HttpPost]
        [Route("Subtract")]
        public ObjectResult Subtract(decimal value1, decimal value2)
        {
            decimal returnValue;
            try
            {
                returnValue = Calculations.Subtract(value1, value2);
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult($"Invalid Request: {e.Message}");
            }
            return new OkObjectResult(returnValue);
        }

        // POST <CalculatorController>/Multiply
        [HttpPost]
        [Route("Multiply")]
        public ObjectResult Multiply(decimal value1, decimal value2)
        {
            decimal returnValue;
            try
            {
                returnValue = Calculations.Multiply(value1, value2);
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult($"Invalid Request: {e.Message}");
            }
            return new OkObjectResult(returnValue);
        }

        // POST <CalculatorController>/Divide
        [HttpPost]
        [Route("Divide")]
        public ObjectResult Divide(decimal value1, decimal value2)
        {
            decimal returnValue;
            try
            {
                returnValue = Calculations.Divide(value1, value2);
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult($"Invalid Request: {e.Message}");
            }
            return new OkObjectResult(returnValue);
        }


    }
}
