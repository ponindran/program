using System;

namespace Store.Infrastructure.BaseEntity
{
    public interface IBaseEntity
    {
        DateTime CreatedOn { get; set; }
    }
}
