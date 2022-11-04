using CustomilyNetCoreApi.Models;

namespace CustomilyNetCoreApi.Handlers
{
    public interface IPageService
    {
        Task<List<string>> GetMatchedPages((string, string) values, CancellationToken ct);
        Task<int> TryAddPage(Page entity, CancellationToken ct);
    }
}
