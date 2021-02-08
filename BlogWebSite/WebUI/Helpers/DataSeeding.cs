using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebUI.Helpers
{
    public static class DataSeeding
    {
        public static void Seed(this IApplicationBuilder applicationBuilder){
            IServiceScope serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            MyDbContext dbContext = serviceScope.ServiceProvider.GetService<MyDbContext>();

            Category category = new Category{
                Name = "Bilim Kurgu",
                CreatedAt = DateTime.Now
            };

            User user= new User{
                Name = "abayraktar",
                Email = "alihan.bayraktar@siemens.com",
                Password = "test123",
                CreatedAt = DateTime.Now
            };

            Post post = new Post{
                Title = "Bla bla bla",
                Excerpt = "bla blah blah",
                Content = "esc esc esc",
                Category = category,
                User = user,
                CreatedAt = DateTime.Now
            };

            List<Post> posts = new List<Post>();
            posts.Add(post);

            post = new Post{
                Title = "Bla bla bla g",
                Excerpt = "bla blah blah fff",
                Content = "esc esc esc ffff",
                Category = category,
                User = user,
                CreatedAt = DateTime.Now
            };
            posts.Add(post);
            

            dbContext.Database.Migrate();

            if(dbContext.Database.GetPendingMigrations().Count() == 0){
                if(dbContext.Posts.Count() == 0){
                    dbContext.Posts.AddRange(posts);
                }

                dbContext.SaveChanges();
            }

        }
    }
}