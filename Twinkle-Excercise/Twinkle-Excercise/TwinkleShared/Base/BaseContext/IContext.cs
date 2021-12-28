using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Twinkle.BaseContext
{
    public interface IContext : IDisposable
    {
        #region 
        DbContext DbContext { get; }

        #endregion
    }
}
