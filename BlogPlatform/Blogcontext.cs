using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class Blogcontext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb; Database=Blogcontext_3; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().HasData(

              new Category() { Id = 1, Name = "Technology" },
              new Category() { Id = 2, Name = "Photography" },
              new Category() { Id = 3, Name = "Travel" }
             );

            modelbuilder.Entity<Content>().HasData(
                new Content() { Id = 1, Title = "Software technologies", Body = "Innovative technologies offer more immersive experiences like AR and VR. Virtual Reality immerses the user in a simulated environment, Augmented Reality is an overlay of technology in the real world. CISCO forecasts that globally, AR-VR traffic will increase 12-fold by 2022 in all fields of entertainment.", Author = "Tom B.", PublishDate = new DateTime(2021, 10, 13), CategoryId = 1},
                new Content() { Id = 2, Title = "Photography styles", Body = "When most people think of fine art photography, their mind flashes to still lifes. Still lifes come in many forms, from the mundane art school bowl of fruit to the visually interesting digital creations you see online today. Still lifes can fall into any genre or class of photography, and it's a fundamental skill that all shutterbugs should try to master.", Author = "John T.", PublishDate = new DateTime(2020, 08, 02), CategoryId = 2},
                new Content() { Id = 3, Title = "Best places to travel to this year", Body = "India, Morocco and Vietnam were ranked the top 3 best places to travel in 2021...", Author = "Joe S.", PublishDate = new DateTime(2021, 10, 01), CategoryId = 3}
             );

            

        }
    }
}
