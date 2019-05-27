using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Context;
using Infra.Models;

namespace Infra.Repository
{
    public class TodoRepository
    {
        private readonly TodoContext _context = new TodoContext();


        public async Task<IEnumerable<TodoItem>> GetAllItems()
        {
            return await  _context.TodoItems.ToListAsync();
        }



    }
}
