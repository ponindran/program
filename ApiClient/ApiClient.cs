using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace VA.Api.Basket.Proxies
{
    public class ApiClient : IApiClient
    {
        public const string EMPTY_RESPONSE = "EMPTY_RESPONSE";

        public ApiClient( )
        {
            
        }

        /// <summary>
        /// To call the post endpoint
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="authToken"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public async Task<T> PostAsync<T>(RequestParams request)
        {

            StringContent content = null;
            string payloadText = null;
            
            if (request.PayLoad != null)
            {
                payloadText = JsonConvert.SerializeObject(request.PayLoad);
                content = new StringContent(payloadText, Encoding.UTF8, "application/json");
            }

            using (var apiClient = GetApiClient(request.AuthToken))
            {

                //apiClient.DefaultRequestHeaders.Add(Constant.HeaderKey, request.CorrelationId);
                var response = await apiClient.PostAsync(request.Endpoint, content);
                var contentText = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    

                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        throw new System.Exception($"Exception occurred in endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                    else
                    {
                        throw new System.Exception($"Exception occurred in endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                    if (string.IsNullOrEmpty(contentText) || contentText.Length == 0)
                    {
                        throw new ApplicationException(EMPTY_RESPONSE);
                    }
                    var displayMessage = ExtractJsonMessage(contentText) ?? contentText;

                    return JsonConvert.DeserializeObject<T>(contentText);
                }
            }
        }

        /// <summary>
        /// To call the post endpoint
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="authToken"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public async Task<T> DeleteAsync<T>(RequestParams request)
        {
            StringContent content = null;
            string payloadText = null;

            
            if (request.PayLoad != null)
            {
                payloadText = JsonConvert.SerializeObject(request.PayLoad);
                content = new StringContent(payloadText, Encoding.UTF8, "application/json");
            }

            using (var apiClient = GetApiClient(request.AuthToken))
            {
                
                HttpRequestMessage httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(request.PayLoad), System.Text.Encoding.UTF8, "application/json");
                httpRequest.RequestUri = new Uri(request.Endpoint);

                var response = await apiClient.SendAsync(httpRequest);
                var contentText = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    

                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        throw new System.Exception($"Bad Requst from endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                    else
                    {
                        throw new System.Exception($"Exception occurred in endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                    if (string.IsNullOrEmpty(contentText) || contentText.Length == 0)
                    {
                        
                        throw new ApplicationException(EMPTY_RESPONSE);
                    }
                    var displayMessage = ExtractJsonMessage(contentText) ?? contentText;

                    
                    return JsonConvert.DeserializeObject<T>(contentText);
                }
            }
        }

        public async Task<T> GetAsync<T>(RequestParams request)
        {
            

            using (var apiClient = GetApiClient(request.AuthToken))
            {
               
                var response = await apiClient.GetAsync(request.Endpoint);
                var contentText = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {

                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        throw new System.Exception($"Bad Requst from endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                    else
                    {
                        throw new System.Exception($"Exception occurred in endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                    if (string.IsNullOrEmpty(contentText) || contentText.Length == 0)
                    {
                        throw new ApplicationException(EMPTY_RESPONSE);
                    }
                    var displayMessage = ExtractJsonMessage(contentText) ?? contentText;
                    return JsonConvert.DeserializeObject<T>(contentText);
                }
            }
        }


        public async Task<T> SendAsync<T>(RequestParams request)
        {
            StringContent payloadMsg = null;
            string payloadText = null;

            if (request.PayLoad != null)
            {
                payloadText = JsonConvert.SerializeObject(request.PayLoad);
                payloadMsg = new StringContent(payloadText, Encoding.UTF8, "application/json");
            }
            var httpRequest = new HttpRequestMessage {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(request.Endpoint),
                Content = payloadMsg
            };

            using (var apiClient = GetApiClient(request.AuthToken))
            {
                var response = await apiClient.SendAsync(httpRequest);
                var contentText = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {

                    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        throw new System.Exception($"Bad Requst from endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                    else
                    {
                        throw new System.Exception($"Exception occurred in endpoint {request.Endpoint} - Error {contentText} {response.ReasonPhrase}");
                    }
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                    if (string.IsNullOrEmpty(contentText) || contentText.Length == 0)
                    {
                        
                        throw new ApplicationException(EMPTY_RESPONSE);
                    }
                    var displayMessage = ExtractJsonMessage(contentText) ?? contentText;

                   
                    return JsonConvert.DeserializeObject<T>(contentText);
                }
            }
        }


        private HttpClient GetApiClient(string authToken)
        {
            if (authToken == null)
            {
                throw new AuthenticationException("Auth Token is null");
            }

            var apiHttpClient = new HttpClient();
            apiHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));
            if (!string.IsNullOrWhiteSpace(authToken))
            {
                apiHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authToken);
            }

            return apiHttpClient;
        }

        private string ExtractJsonMessage(string responseContent)
        {
            try
            {
                return JArray.Parse(responseContent).FirstOrDefault()?.ToString(Newtonsoft.Json.Formatting.Indented) ?? responseContent;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}


