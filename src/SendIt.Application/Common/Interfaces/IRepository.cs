namespace SendIt.Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync();
        Task<TEntity> UpdateAsync();
        Task<TEntity> DeleteAsync();
    }
}
