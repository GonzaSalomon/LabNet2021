namespace Trabajo.EF.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Trabajo.EF.Entities;

    public partial class NorthwindContextCategories : DbContext
    {
        public NorthwindContextCategories()
            : base("name=NorthwindConnectionCategories")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
