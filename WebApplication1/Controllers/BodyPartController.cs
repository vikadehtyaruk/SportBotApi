using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Clients;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BodyPartController : ControllerBase
    {
        [HttpGet(Name = "GetExerciseByBodyPart")]
        public List<Sport> GetExercisesByName(string BodyPart)
        {
            ExerciseClient client = new ExerciseClient();
            return client.GetExerciseByBodyPartAsync(BodyPart).Result;
        }
    }
}
