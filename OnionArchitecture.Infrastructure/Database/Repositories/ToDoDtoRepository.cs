using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Infrastructure.Database.Dtos;
using OnionArchitecture.Infrastructure.Database.Interfaces;

namespace OnionArchitecture.Infrastructure.Database.Repositories
{
    public class ToDoDtoRepository : IToDoDtoRepository
    {
        private readonly EfDbContext _dbContext;

        public ToDoDtoRepository(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save(ToDoDto toDo)
        {
            _dbContext.ToDos.Add(toDo);
            _dbContext.SaveChanges();
        }
    }
}
