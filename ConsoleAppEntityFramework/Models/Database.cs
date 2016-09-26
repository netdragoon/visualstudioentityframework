using System;
using System.Data.Entity;

namespace ConsoleAppEntityFramework.Models
{
    public class Database: DbContext
    {
        public Database()
            :base(@"Server=.\SQLExpress;Database=myDataBase;User Id=sa;Password=senha;MultipleActiveResultSets=true;")
        {

        }
        public DbSet<Group> Group { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(GroupMap.Create());            
        }
    }
}
