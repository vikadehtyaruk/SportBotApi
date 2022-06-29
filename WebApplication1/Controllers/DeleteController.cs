using Microsoft.AspNetCore.Mvc;
using WebApplication1.Clients;
using WebApplication1.Model;
using WebApplication1.Constant;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeleteController : ControllerBase
    {
        [HttpDelete(Name = "{id:long}")]
        public async Task<string> DeleteExercise(long userid, string name)
        {
            var result = DeleteClient.DeleteExercises(userid, name);
            return result;
        }
        
    }
}
