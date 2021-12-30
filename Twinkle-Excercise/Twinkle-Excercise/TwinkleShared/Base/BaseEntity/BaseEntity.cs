using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infrastructure.BaseEntity
{
    public class BaseEntity : IBaseEntity
    {
        public DateTime CreatedOn { get; set; }
    }
}
