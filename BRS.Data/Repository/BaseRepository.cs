using BRS.Data.Context;
using BRS.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.Repository
{
    /// <summary>
    /// Base Repository Main Class
    /// </summary>
    /// <typeparam name="TEntity">DB Entity</typeparam>
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : class
    {
        #region Data Context

        /// <summary>
        /// Entity Framework: DB Context
        /// </summary>
        private BRSContext context;

        /// <summary>
        /// Contains the Entity Framework DBContext.
        /// </summary>
        protected BRSContext Context
        {
            get
            {
                if (this.context == null)
                    this.context = new BRSContext();

                return this.context;
            }
        }

        #endregion

        #region Base CRUD Methods

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await this.Context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> FindByIdAsync(int id)
        {
            return await this.Context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task SaveAsync(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
            await this.Context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (this.Context != null)
                this.Context.Dispose();
        }

        #endregion
    }
}
