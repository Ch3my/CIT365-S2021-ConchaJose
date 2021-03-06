﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCTutorial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTutorial.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    //DB has been seeded
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2019-06-28"),
                        Genre = Genre.Documental,
                        Price = 7.99M,
                        Rating = "E",
                        ImgSrc = "/meet-mormons.jpg"
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven 2: Fire of Faith",
                        ReleaseDate = DateTime.Parse("1998-10-10"),
                        Genre = Genre.Drama,
                        Price = 5.99M,
                        Rating = "E",
                        ImgSrc = "https://pics.filmaffinity.com/the_other_side_of_heaven_2_fire_of_faith-457037403-large.jpg"

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
