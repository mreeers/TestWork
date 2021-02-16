using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadLangJsonController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public UploadLangJsonController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost("{lang}/upload")]
        public async Task<ActionResult> UploadLangJson([FromBody]Language json, string lang)
        {
            using (StreamWriter file = System.IO.File.CreateText($"{_env.WebRootPath}\\{lang}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, json,);
            }



            return Ok();
        }
    }
}
