using System.Data.Entity.ModelConfiguration;
using Infra.Models;

namespace Infra.Mappings  
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.Email);
            HasMany(x => x.Items);
        }
    }
}
