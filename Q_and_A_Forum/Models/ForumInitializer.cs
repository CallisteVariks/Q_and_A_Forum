using Q_and_A_Forum.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q_and_A_Forum.Models
{
    public class ForumInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ForumDbContext>
    {
        protected override void Seed(ForumDbContext context)
        {
           
           
        }
    }
}