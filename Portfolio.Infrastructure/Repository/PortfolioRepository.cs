using Microsoft.EntityFrameworkCore;

namespace Portfolio.Infrastructure.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        public PortfolioDbContext _Context { get; set; }

        public PortfolioRepository(PortfolioDbContext context)
        {
            _Context = context;
        }

        public T Add<T>(T entity) where T : class
        {
            return _Context.Set<T>().Add(entity).Entity;
        }

        public void AddRange<T>(List<T> entities) where T : class
        {
            _Context.AddRange(entities);
        }
        public void RemoveRange<T>(List<T> entities) where T : class
        {
            _Context.RemoveRange(entities);
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _Context.Set<T>().AsQueryable();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            return (await _Context.Set<T>().ToListAsync());
        }

        public T Remove<T>(T entity) where T : class
        {
            return _Context.Set<T>().Remove(entity).Entity;
        }
        public Task<int> SaveChangesAsync()
        {
            return _Context.SaveChangesAsync();
        }

        public void Update<T>(T entity) where T : class
        {
            _Context.Set<T>().Update(entity);
        }

    }
}
