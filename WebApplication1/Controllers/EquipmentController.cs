using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Clients;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        [HttpGet(Name = "GetExerciseByEquipment")]
        public List<Sport> GetExercisesByTarget(string Equipment)
        {
            ExerciseClient client = new ExerciseClient();
            return client.GetExerciseByEquipmentAsync(Equipment).Result;
        }
    }
}
