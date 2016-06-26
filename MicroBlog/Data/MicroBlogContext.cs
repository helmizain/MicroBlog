using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MicroBlog.Data
{
    public class MicroBlogContext : DbContext
    {
        public MicroBlogContext()
          : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
              new MigrateDatabaseToLatestVersion<MicroBlogContext, MicroBlogMigrationsConfiguration>()
              );
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }

    }
}