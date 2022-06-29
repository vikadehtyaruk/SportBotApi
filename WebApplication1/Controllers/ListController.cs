using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Clients;
using WebApplication1.Constant;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListController : ControllerBase
    {
        [HttpGet(Name = "GetExerciseFromList")]
        public async Task<string[]> FavouriteExercises( long userid )
        {
            string result = "Sorry, we didn't find anything:(";
            ListClient client = new ListClient();
            string[] vs = new string[] { };
            StreamReader streamReader = new StreamReader(Constants.path);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                var obj = JsonConvert.DeserializeObject<FavoriteExercises>(line);
                if (obj._userid == userid)
                {
                    vs = (string[])vs.Concat( new[] { obj._name } ).ToArray();
                }
            }
            streamReader.Close();
            return vs;

        }
    }
}
