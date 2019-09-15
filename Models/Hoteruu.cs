namespace Hoteru.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Hoteruu : DbContext
    {
        public Hoteruu()
            : base("name=Hoteruu")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_id);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Rooms)
                .WithOptional(e => e.Hotel)
                .HasForeignKey(e => e.Hotel_id);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Room)
                .HasForeignKey(e => e.Room_id);
        }
    }
}
