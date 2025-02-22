using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Infrastructure.Repository
{
    public interface IPortfolioRepository
    {
        T Add<T>(T entity) where T : class;

        T Remove<T>(T entity) where T : class;

        void RemoveRange<T>(List<T> entities) where T : class;

        void AddRange<T>(List<T> entities) where T : class;

        IQueryable<T> GetAll<T>() where T : class;

        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;

        Task<int> SaveChangesAsync();
        void Update<T>(T entity) where T : class;
    }
}
