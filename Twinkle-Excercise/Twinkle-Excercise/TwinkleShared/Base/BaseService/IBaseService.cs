using Store.Twinkle.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Twinkle.BaseService
{
    public interface IBaseService<T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> SoftDeleteAsync(T entity);
        Task<T> GetByIdAsync(long id, bool isTracked = true);
        Task<List<T>> SearchAsync(ISearchCondition<T> searchCondition = null);
    }
}
