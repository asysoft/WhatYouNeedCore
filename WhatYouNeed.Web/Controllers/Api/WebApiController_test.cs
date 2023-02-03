
using Microsoft.AspNetCore.Mvc;
using WhatYouNeed.Web.Models;

namespace WhatYouNeed.Web.Controllers.Api
{
    [ApiController]
    [Route("[controller]")]
    public class WebApiController_test : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WebApiController_test> _logger;

        public WebApiController_test(ILogger<WebApiController_test> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetListingModel")]
        public IEnumerable<ListingModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ListingModel
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = Random.Shared.Next(-20, 55),
                //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}