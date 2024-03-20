using PostLand.Domain;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PostLand.Persistence
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options)
           : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = "1",
                Title = "Introduction to CQRS and Mediator Patterns",
        
            });

        }
    }

}