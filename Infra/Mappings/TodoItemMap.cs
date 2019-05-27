using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using Infra.Models;

namespace Infra.Mappings
{
    public class TodoItemMap : EntityTypeConfiguration<TodoItem>
    {
        public TodoItemMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.IsComplete);
        }
    }
}
