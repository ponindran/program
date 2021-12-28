using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA.Api.Basket.Proxies
{
    public class RequestParams
    {
        public string Endpoint { get; set; }
        public string AuthToken { get; set; }
        public object PayLoad { get; set; }
        public string CorrelationId { get; set; }
    }
}
