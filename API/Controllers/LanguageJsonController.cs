using Application.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Models.Model.JSON;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageJsonController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public LanguageJsonController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost("{lang}/upload")]
        public ActionResult UploadLangJson([FromBody]Language json, string lang)
        {
            string path = $@"{_env.WebRootPath}/lang";
            try
            {
                var saveJson = new JsonLanguage();
                saveJson.AddJsonLanguage(json, lang, path);
                return Ok("Файл успешно сохранен");
            }
            catch(Exception err)
            {
                return BadRequest("Произошла ошибка: " + err.Message);
            }
        }
    }
}
