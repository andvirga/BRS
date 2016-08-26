using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Interfaces.Repository
{
    /// <summary>
    /// Generic Base Repository Interface
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    public interface IBaseRepository<TEntity> : IDisposable
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> FindByIdAsync(int id);

        Task CreateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
