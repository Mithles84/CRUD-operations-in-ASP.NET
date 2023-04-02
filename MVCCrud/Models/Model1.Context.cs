
namespace MVCCrud.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCCrudOperationsEntities : DbContext
    {
        public MVCCrudOperationsEntities()
            : base("name=MVCCrudOperationsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Customer> Customers { get; set; }
    }
}
