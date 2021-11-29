using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public interface IScalerepository
    {
        public void Insertdata(Scale sclEntity);
        public IEnumerable<Scale> SelectALLQuantity();
        public Scale UpdateData(int id, Scale sclEntity);
        public IEnumerable<Scale> DeleteData(int id);

    }

}
