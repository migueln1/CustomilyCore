using CustomilyNetCoreApi.Handlers;
using CustomilyNetCoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomilyNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly IPageService _pageService;
        public PagesController(IPageService pageService)
        {
            _pageService = pageService;
        }
        [HttpGet(Name = "GetPages")]
        public async Task<IEnumerable<string>> Get((string,string) values, CancellationToken ct)
        {
            await _pageService.GetMatchedPages(values, ct);
        }
    }
}
