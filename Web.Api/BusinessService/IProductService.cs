using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web.Api.BusinessService
{
    public interface IProductService
    {
        public void InserData(Product prodto);
    }
}
