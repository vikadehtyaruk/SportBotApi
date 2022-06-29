using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Clients;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet(Name = "GetExerciseByName")]
        public List<Sport> GetExercisesByName(string Name)
        {
            ExerciseClient client = new ExerciseClient();
            return client.GetExerciseByNameAsync(Name).Result;
        }
        [HttpPost(Name = "AddFavorites")]
        public void ListofаvExercises(string name, long userid)
        {
            Clients.ListClient.ListofFavExercises(name, userid);
        }
    }
}
