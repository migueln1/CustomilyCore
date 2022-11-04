using CustomilyNetCoreApi.DataLayer.Repositories;
using CustomilyNetCoreApi.Models;

namespace CustomilyNetCoreApi.Handlers
{
    public class PageService : IPageService
    {
        public Task<List<string>> GetMatchedPages((string, string) values, CancellationToken ct)
        {
            var allPages = 
        }

        //TODO Si da tiempo usar Mediatr
        public async Task<int> TryAddPage(Page entity, CancellationToken ct)
        {
            try
            {
                var pageRepo = new PageRepository();
                var result = await pageRepo.TryAddAsync(entity, ct);
                return result.Id;

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
