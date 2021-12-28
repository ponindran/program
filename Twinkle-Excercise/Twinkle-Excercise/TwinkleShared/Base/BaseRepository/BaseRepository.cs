using Microsoft.EntityFrameworkCore;
using Store.Twinkle.BaseContext;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Store.Twinkle.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly Context _context;
        public BaseRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task CreateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await this._context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Create Async failed", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task DeleteAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await this._context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Delete failed", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> FindAll()
        {
            return this._context.Set<T>().AsNoTracking();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression).AsNoTracking();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual async Task UpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Update failed ",ex);
            }

        }
    }
}
