using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopGiaySolution.Data.Configurations;
using ShopGiaySolution.Data.Entities;
using ShopGiaySolution.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Data.EF
{
    public class ShopGiaydbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public ShopGiaydbContext(DbContextOptions options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());

            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());


            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);




            //data seeding
            modelBuilder.Seed();
            // base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<AppConfig> AppConfigs { get; set; } = null!;

        public DbSet<Cart> Carts { get; set; } = null!;

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; } = null!;
        public DbSet<ProductInCategory> ProductInCategories { get; set; } = null!;

        public DbSet<Contact> Contacts { get; set; } = null!;

        public DbSet<Language> Languages { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<ProductTranslation> ProductTranslations { get; set; } = null!;

        public DbSet<Promotion> Promotions { get; set; } = null!;

        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<ProductImage> ProductImages { get; set; } = null!;




    }
}
