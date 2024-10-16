using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAHSUN;initial Catalog=CarBookDb;integrated security=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                 .HasOne(c => c.Brand)
                 .WithMany(b => b.Cars)
                 .HasForeignKey(c => c.BrandId);

            modelBuilder.Entity<CarFeature>()
                .HasOne(c => c.Feature)
                .WithMany(cf => cf.CarFeatures)
                .HasForeignKey(cf => cf.FeatureId);
            modelBuilder.Entity<CarFeature>()
                .HasOne(c => c.Car)
                .WithMany(f => f.CarFeatures)
                .HasForeignKey(cf => cf.CarId);

            modelBuilder.Entity<RentACar>()
                .HasOne(c => c.Car)
                .WithMany(a => a.RentACars)
                .HasForeignKey(x => x.CarId);
            modelBuilder.Entity<RentACar>()
                .HasOne(c => c.Location)
                .WithMany(a => a.RentACars)
                .HasForeignKey(rc => rc.LocationId);
            

            modelBuilder.Entity<RentACarProcess>()
                .HasOne(c => c.Car)
                .WithMany(a => a.RentACarProcesses)
                .HasForeignKey(x => x.CarId);
            modelBuilder.Entity<RentACarProcess>()
                .HasOne(c => c.Customer)
                .WithMany(a => a.RentACarProcesses)
                .HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<RentACarProcess>().Property(e => e.PickUpDate).HasColumnType("Date");
            modelBuilder.Entity<RentACarProcess>().Property(e => e.DropOffDate).HasColumnType("Date");
            modelBuilder.Entity<RentACarProcess>().Property(e => e.PickUpTime).HasColumnType("Time");
            modelBuilder.Entity<RentACarProcess>().Property(e => e.DropOffTime).HasColumnType("Time");


            modelBuilder.Entity<Reservation>()
                        .HasOne(x=>x.PickUpLocation)
                        .WithMany(y=>y.PickUpReservations)
                        .HasForeignKey(z=>z.PickUpLocationId)
                        .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>()
                        .HasOne(x => x.DropOffLocation)
                        .WithMany(y => y.DropOffReservations)
                        .HasForeignKey(z => z.DropOffLocationId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        
        
    }
}
