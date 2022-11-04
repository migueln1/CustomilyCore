using CustomilyNetCoreApi.DataLayer.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CustomilyNetCoreApi.DataLayer.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly CustomilyDbContext _context;
        public BaseRepository(CustomilyDbContext context)
        {
            _context = context;
        }
        public async Task<IList<T>> GetAll(CancellationToken ct)
            => await _context.Set<T>().ToListAsync(ct);

        public async Task<T> TryAddAsync(T entity, CancellationToken ct)
        {
            using (var context = new CustomilyDbContext())
            {
                await context.Set<T>().AddAsync(entity, ct);
                await context.SaveChangesAsync(ct);
                return entity;
            }
        }
    }
}