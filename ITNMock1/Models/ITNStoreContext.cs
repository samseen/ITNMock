using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNMock1.Models
{
    public class ITNStoreContext : DbContext
    {

        public ITNStoreContext(DbContextOptions<DbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ITNStore> ITNStores { get; set; }
    }
}
