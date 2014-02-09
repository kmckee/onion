using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Infrastructure.Database.Dtos;

namespace OnionArchitecture.Infrastructure.Database
{

    public class EfDbContext : DbContext
    {
        public IDbSet<ToDoDto> ToDos { get; set; }
    }
}
