using Microsoft.EntityFrameworkCore;
namespace Kursach.Models
{
    public partial class Context : DbContext
    {
        #region Constructor
        public Context(DbContextOptions<Context>
        options)
        : base(options)
        { }
        #endregion
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        //protected override void OnModelCreating(ModelBuilder
        //modelBuilder)
        //{
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.Property(e => e.Login).IsRequired();
        //    });

        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.Property(e => e.ProductName).IsRequired();
        //    });

        //    modelBuilder.Entity<Order>(entity =>
        //    {
        //        entity.Property(e => e.Date).IsRequired();
        //    });

        //    modelBuilder.Entity<Basket>(entity =>
        //    {
        //        entity.Property(e => e.ProductId).IsRequired();
        //    });
        //}
    }
}
