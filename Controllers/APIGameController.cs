using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeverGame106.Models;

namespace SeverGame106.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIGameController : ControllerBase
    {
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "Game 106",
                Name = "Ngo Van Dung",
                StundentCode = "PD11279",
                Class = "GA19302",

            };
            int status = 1;
            string message = "Get data success!";
            var data = new{status, message, game106};
            return new JsonResult(data);

        }
    }
}
