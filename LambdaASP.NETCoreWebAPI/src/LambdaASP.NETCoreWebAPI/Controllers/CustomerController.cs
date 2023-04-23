using Microsoft.AspNetCore.Mvc;

namespace LambdaASP.NETCoreWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
   [HttpGet]
   public JsonResult GetCustomer()
   {
      return new JsonResult(new
      {
         CustomerName = "Test Customer 123",
         CustomerCity = "Praia Grande",
         CellPhone = "1197878798"
      });
   }
}