namespace CustomilyNetCoreApi.DataLayer.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> TryAddAsync(T entity, CancellationToken ct);
        Task<IList<T>> GetAll(CancellationToken ct);

        //TODO Otros métodos crud
    }
}