using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplashStats.API.Models.ScheduleDtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SplashStats.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        public readonly IConfiguration Configuration;
        public HttpClient SharedClient;
        public string ApiKey { get; set; }


        public StatsController(IConfiguration configuration)
        {
            Configuration = configuration;
            SharedClient = new HttpClient();
            SharedClient.BaseAddress = new Uri(Configuration["BaseURL"]);
            ApiKey = Configuration["ApiKey"];
        }


        [HttpGet("Schedule/{seasonYear?}/{seasonType?}")]
        public async Task<ActionResult> GetSchedule(int seasonYear = 2023, string seasonType = "REG")
        {

            try
            {
                string resource = $"games/{seasonYear}/{seasonType.ToUpper()}/schedule.json?api_key={ApiKey}";
                
                using HttpResponseMessage response = await SharedClient.GetAsync(resource);

                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest();
                }

                var json = await response.Content.ReadFromJsonAsync<Schedule>();

                Console.WriteLine(json);

                return Ok(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }


        }

    }
}

