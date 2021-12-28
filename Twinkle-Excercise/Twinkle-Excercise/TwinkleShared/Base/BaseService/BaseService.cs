using Store.Twinkle.BaseModel;
using Store.Twinkle.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Twinkle.BaseService
{
    public class BaseService <T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _dal;
        public BaseService(IBaseRepository<T> dal)
        {
            _dal = dal;
        }

        public virtual async Task CreateAsync(T entity)
        {
            try
            {
                await _dal.CreateAsync(entity);
            }
            catch (Exception ex) 
            {
                throw new ApplicationException("Create Async", ex);
            }

        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                await _dal.DeleteAsync(entity);
                return true;
            }
            catch (Exception ex)  
            {
                throw new ApplicationException("Delete Async", ex);
            }

        }

        public async virtual Task<T> GetByIdAsync(long id, bool isTracked = true)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> SearchAsync(ISearchCondition<T> searchCondition = null)
        {
            try
            {
                var entities = new List<T>();
                if (searchCondition != null)
                    entities = _dal.FindByCondition(searchCondition.Predicate).ToList();
                else
                    entities = _dal.FindAll().ToList();
                return Task.FromResult(entities);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Search Async Failed", ex);
            }
        }

        public Task<bool> SoftDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            try
            {
                await _dal.UpdateAsync(entity);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Update Async Failed", ex);
            }

        }
    }
}
