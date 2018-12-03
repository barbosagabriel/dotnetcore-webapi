using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ToDoItemRepository : RepositoryBase<ToDoItem>, IToDoItemRepository
    {
        public ToDoItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
