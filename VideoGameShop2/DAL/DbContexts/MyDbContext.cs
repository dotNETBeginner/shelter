using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DAL.DbContexts
{
    public class MyDbContext : IdentityDbContext<User>
    {
        DbSet <Developer> Developers { get; set; }
        DbSet <Game> Games { get; set; }
        DbSet <Genre> Genres { get; set;}
        DbSet <Publisher> Publishers { get; set; }
        DbSet <User> Users { get; set; }
        DbSet <UserBought> UserBoughts { get; set; }
        

        public MyDbContext(DbContextOptions<MyDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            //Developer
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Developer>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Developer>()
                .Property(p => p.Name)
                .HasMaxLength(50);
            modelBuilder.Entity<Developer>()
                .HasOne<Publisher>()
                .WithMany()
                .HasForeignKey(p => p.Id_Publisher);

            //Game
            modelBuilder.Entity<Game>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Game>()
                .Property(p => p.Name)
                .HasMaxLength(50);
            modelBuilder.Entity<Game>()
                .HasOne<Developer>()
                .WithMany()
                .HasForeignKey(p => p.Id_Dev);
            modelBuilder.Entity<Game>()
                .HasOne<Genre>()
                .WithMany()
                .HasForeignKey(p => p.Id_Genre);

            //Genre
            modelBuilder.Entity<Genre>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Publisher>()
                .Property(p => p.Name)
                .HasMaxLength(50);

            //Publisher
            modelBuilder.Entity<Publisher>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Publisher>()
                .Property(p => p.Name)
                .HasMaxLength(50);

            //UserBought
            modelBuilder.Entity<UserBought>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<UserBought>()
                .HasOne<Game>()
                .WithMany()
                .HasForeignKey(p => p.Id_Game);
            modelBuilder.Entity<UserBought>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.Id_User);

            //User
            modelBuilder.Entity<User>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<User>()
                .Property(p => p.UserName)
                .HasMaxLength(30);
            modelBuilder.Entity<User>()
                .Property(p => p.PasswordHash)
                .HasMaxLength(50);

        }
    }
}
