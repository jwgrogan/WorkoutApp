using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutApp
{
    public class GymDb : DbContext

    {

        public DbSet<User> Users { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBUilder)
        {
            optionsBUilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GymDb;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(ukey => ukey.UserNumber);

                entity.Property(u => u.UserNumber).ValueGeneratedOnAdd();

                entity.Property(u => u.Username).IsRequired().HasMaxLength(50);

                entity.Property(u => u.EmailAddress).IsRequired().HasMaxLength(50);

                entity.Property(w => w.CreateDate).IsRequired();

            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.ToTable("Workouts");

                entity.HasKey(wkey => wkey.WorkoutNumber);

                entity.Property(w => w.WorkoutNumber).ValueGeneratedOnAdd();

                entity.Property(w => w.WorkoutDate).IsRequired();

                entity.Property(w => w.WorkoutType).IsRequired();

                entity.Property(w => w.WorkoutDuration).IsRequired();

            });
        }
    }
}
