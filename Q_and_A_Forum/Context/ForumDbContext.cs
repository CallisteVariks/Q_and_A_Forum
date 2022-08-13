using Q_and_A_Forum.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Q_and_A_Forum.Context
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(): base("ForumDbContext") {
            Database.SetInitializer<ForumDbContext>(new ForumInitializer());
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}