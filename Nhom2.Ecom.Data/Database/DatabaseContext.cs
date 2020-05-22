namespace Nhom2.Ecom.Data.Database
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<TestTable> Tests { get; set; }
        //public virtual DbSet<Blog> Blogs { get; set; }
        //public virtual DbSet<BlogComment> BlogComments { get; set; }
        //public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        //public virtual DbSet<Order> Orders { get; set; }
        //public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        //public virtual DbSet<OrderTracking> OrderTrackings { get; set; }
        //public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<ProductComment> ProductComments { get; set; }
        //public virtual DbSet<ProductRate> ProductRates { get; set; }
        //public virtual DbSet<PromotionCode> PromotionCodes { get; set; }
        //public virtual DbSet<Province> Provinces { get; set; }
        //public virtual DbSet<Shop> Shops { get; set; }
        //public virtual DbSet<Status> Status { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        //public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Admin>()
            //    .HasMany(e => e.Blogs)
            //    .WithOne(e => e.Admin)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<Admin>()
            //    .HasMany(e => e.Orders)
            //    .WithOne(e => e.Admin)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<Admin>()
            //    .HasMany(e => e.Products)
            //    .WithOne(e => e.Admin)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<Blog>()
            //    .HasMany(e => e.BlogComments)
            //    .WithOne(e => e.Blog)
            //    .HasForeignKey(e => e.ParentID);

            ////modelBuilder.Entity<Category>()
            ////    .HasMany(e => e.Products)
            ////    .WithMany(e => e.Categories)
            ////    .Map(m => m.ToTable("CategoryDetail").MapLeftKey("CategoryID").MapRightKey("ProductID"));

            //modelBuilder.Entity<CategoryDetail>()
            //    .HasKey(cd => new { cd.CategoryID, cd.ProductID });

            //modelBuilder.Entity<CategoryDetail>()
            //    .HasOne(e => e.Product)
            //    .WithMany(e => e.CategoryDetails)
            //    .HasForeignKey(cd => cd.ProductID);

            //modelBuilder.Entity<CategoryDetail>()
            //    .HasOne(e => e.Category)
            //    .WithMany(e => e.CategoryDetails)
            //    .HasForeignKey(cd => cd.CategoryID);

            //modelBuilder.Entity<OrderDetail>()
            //    .HasKey(cd => new { cd.ProductID, cd.OrderID });

            //modelBuilder.Entity<OrderDetail>()
            //    .HasOne(e => e.Product)
            //    .WithMany(e => e.OrderDetails)
            //    .HasForeignKey(cd => cd.ProductID);

            //modelBuilder.Entity<OrderDetail>()
            //    .HasOne(e => e.Order)
            //    .WithMany(e => e.OrderDetails)
            //    .HasForeignKey(cd => cd.OrderID);

            //modelBuilder.Entity<OrderTracking>()
            //    .HasKey(cd => new { cd.StatusID, cd.OrderID });

            //modelBuilder.Entity<OrderTracking>()
            //    .HasOne(e => e.Order)
            //    .WithMany(e => e.OrderTrackings)
            //    .HasForeignKey(cd => cd.OrderID);

            //modelBuilder.Entity<OrderTracking>()
            //    .HasOne(e => e.Status)
            //    .WithMany(e => e.OrderTrackings)
            //    .HasForeignKey(cd => cd.StatusID);

            //modelBuilder.Entity<Customer>()
            //    .HasMany(e => e.ProductRates)
            //    .WithOne(e => e.Customer)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<Order>()
            //    .HasMany(e => e.OrderDetails)
            //    .WithOne(e => e.Order)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Order>()
            //    .HasMany(e => e.OrderTrackings)
            //    .WithOne(e => e.Order)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Product>()
            //    .HasMany(e => e.OrderDetails)
            //    .WithOne(e => e.Product)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Shop>()
            //    .HasMany(e => e.Categories)
            //    .WithOne(e => e.Shop)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<Status>()
            //    .HasMany(e => e.OrderTrackings)
            //    .WithOne(e => e.Status)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.BlogComments)
            //    .WithOne(e => e.User)
            //    .HasForeignKey(e => e.CreateBy);

            //modelBuilder.Entity<User>()
            //    .HasMany(e => e.ProductComments)
            //    .WithOne(e => e.User)
            //    .HasForeignKey(e => e.CreateBy);
        }
    }
}
