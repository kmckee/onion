using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Infrastructure.Database;

namespace OnionArchitecture.IOC
{
    public static class DatabaseHelper
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfDbContext>());
        }
    }
}
