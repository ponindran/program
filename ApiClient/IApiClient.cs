using System.Threading.Tasks;

namespace VA.Api.Basket.Proxies
{
    public interface IApiClient
    {
        Task<T> PostAsync<T>(RequestParams request);
        Task<T> DeleteAsync<T>(RequestParams request);
        Task<T> GetAsync<T>(RequestParams request);
        Task<T> SendAsync<T>(RequestParams request);
    }
}
