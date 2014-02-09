using System.Data.Entity;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Infrastructure.Database;
using OnionArchitecture.Infrastructure.Database.Dtos;
using OnionArchitecture.Infrastructure.Database.Repositories;

namespace OnionArchitecture.UnitTests.Repositories
{
    [TestFixture]
    public class ToDoDtoRepositoryTests
    {
        private EfDbContext _dbContext;
        private IDbSet<ToDoDto> _toDoDbSet;
        private ToDoDtoRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _dbContext = Substitute.For<EfDbContext>();
            _toDoDbSet = Substitute.For<IDbSet<ToDoDto>>();
            _dbContext.ToDos = _toDoDbSet;
            _repository = new ToDoDtoRepository(_dbContext);
        }

        [Test]
        public void Create_adds_the_entity()
        {
            var newDto = new ToDoDto();
            _repository.Save(newDto);

            _dbContext.ToDos.Received().Add(newDto);
        }

        [Test]
        public void Create_saves_the_added_entity()
        {
            _repository.Save(new ToDoDto());

            _dbContext.Received().SaveChanges();
        }
    }
}
