namespace BulkyBookWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db_Context : DbContext
    {
        public Db_Context()
            : base("name=Db_Context")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
