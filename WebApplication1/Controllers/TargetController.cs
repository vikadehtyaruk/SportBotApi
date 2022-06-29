using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Clients;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TargetController : ControllerBase
    {
        [HttpGet(Name = "GetExerciseByTarget")]
        public List<Sport> GetExercisesByTarget(string Target)
        {
            ExerciseClient client = new ExerciseClient();
            return client.GetExerciseByTargetAsync(Target).Result;
        }
    }
}
