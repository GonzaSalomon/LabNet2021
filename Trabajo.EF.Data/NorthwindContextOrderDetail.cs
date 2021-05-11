namespace Trabajo.EF.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Trabajo.EF.Entities;

    public partial class NorthwindContextOrderDetail : DbContext
    {
        public NorthwindContextOrderDetail()
            : base("name=NorthwindConnectionOrderDetail")
        {
        }

        public virtual DbSet<Order_Details> Order_Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
