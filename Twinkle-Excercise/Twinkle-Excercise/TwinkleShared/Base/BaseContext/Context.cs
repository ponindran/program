using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Twinkle.BaseContext
{
    public class Context : DbContext, IContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }
    }
}
