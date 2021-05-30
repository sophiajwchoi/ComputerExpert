using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ComputerExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Component>().HasData(
                    new Component() { Name = "i9-10901K", Price = 498, Id = 6, Type = "Processor" });

            modelBuilder.Entity<Component>().HasData(new Component { Type = "Processor", Price = 399.90, Id = 10, Name = "i7-10700KF" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Processor", Price = 350.90, Id = 15, Name = "i3-10100" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "i3-10900K", Price = 125, Id = 16, Type = "Processor" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Processor", Price = 143, Id = 20, Name = "i3-10300T" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "i9-10900K", Price = 488, Id = 21, Type = "Processor" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Processor", Price = 195, Id = 25, Name = "i5-10500E" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "NVIdIA GeForce RTX 3090", Price = 1499, Id = 2, Type = "Graphics" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Nvidia GeForce RTX 3060 Ti", Price = 1599.90, Id = 7, Type = "Graphics" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Nvidia GeForce RTX 3080", Price = 2740, Id = 12, Type = "Graphics" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "AMD Radeon RX 5600 XT", Price = 1195.10, Id = 17, Type = "Graphics" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Nvidia GeForce RTX 3070", Price = 1899.90, Id = 22, Type = "Graphics" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Memory", Price = 150, Id = 4, Name = "16GB DDR4-2933MHz, 2x8G" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Memory", Price = 400, Id = 9, Name = "32GB DDR4-2933MHz, 2x16G" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Memory", Price = 600.00, Id = 14, Name = "64GB DDR4-2933MHz, 2x32G" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "512GB M.2 PCIe NVMe Solid State Drive", Price = 150, Id = 1, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Seagate BarraCuda 2TB Internal Hard Drive HDD 3.5 Inch SATA 6Gb/s", Price = 64.99, Id = 3, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Storage", Price = 799.99, Id = 5, Name = "1TB M.2 PCIe NVMe Solid State Drive" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Crucial MX500 250GB 3D NAND SATA M.2", Price = 84.72, Id = 8, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "2TB M.2 PCIe NVMe Solid State Drive", Price = 600, Id = 11, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Crucial MX500 500GB 3D NAND SATA M.2", Price = 82.5, Id = 13, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Samsung 870 EVO 500GB SATA 2.5 Internal SSD", Price = 219.99, Id = 18, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Storage", Price = 259.90, Id = 19, Name = "SAMSUNG 970 EVO PLUS M.2 2280 1TB" });
            modelBuilder.Entity<Component>().HasData(new Component { Name = "Samsung 860 EVO 500GB SATA 2.5", Price = 78.80, Id = 23, Type = "Storage" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "Storage", Price = 99.99, Id = 24, Name = "SAMSUNG 970 EVO PLUS M.2 2280 500GB" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "SoundCard", Price = 100, Id = 26, Name = " Onboard Realtek ALC1220-VB HD Audio" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "SoundCard", Price = 141.85, Id = 27, Name = "External USB DAC: Micca OriGen G2" });
            modelBuilder.Entity<Component>().HasData(new Component { Type = "SoundCard", Price = 534.69, Id = 28, Name = " External USB DAC: JDS Labs Element II" });

            modelBuilder.Entity<Computer>().HasData(new Computer
            { Id = 1, Name = "Legion Tower 7i Gaming Desktop", BasePrice =300, BrandName = "Legion", ImageURL = "~/imgs/lenovo-desktop-legion-tower-7i-hero.webp" });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 2, Name = "M70t Tower", BasePrice = 400, BrandName = "ThinkCentre", ImageURL = "~/imgs/lenovo-thinkcentre-m70t-subseries-hero.webp" });
            modelBuilder.Entity<Computer>().HasData(new Computer() { Id = 3, Name = "Legion Tower 5i (AMD) Gaming Computer", BasePrice = 500, BrandName = "Legion", ImageURL = "~/imgs/lenovo-legion-tower-5i-hero.webp" });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 4, Name = "Creator 5i Desktop Tower", BasePrice = 600, BrandName = "LenovoPRO", ImageURL = "~/imgs/lenovo-desktop-ideacentre-creator-5i-subseries-hero.webp" });
            modelBuilder.Entity<Computer>().HasData(new Computer { Id = 5, Name = "IdeaCentre 5 AMD Desktop Tower", BasePrice = 700, BrandName = "Legion", ImageURL = "~/imgs/lenovo-desktops-ideacentre-500series-5-hero.webp" });

 
        }
    }
}
