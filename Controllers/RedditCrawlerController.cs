using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetRedditApi.Controllers
{
    [Route("[controller]")]
    public class RedditCrawlerController : Controller
    {
        public RedditCrawlerController()
        {
        }

        [HttpGet("all")]
        public async Task<HttpContent> All()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://www.reddit.com/.json").ConfigureAwait(false);
                return result.Content;
            }
        }
    }
}
