using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Independence Day",
                    ReleaseDate = DateTime.Parse("1996-7-3"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Spiderman 3",
                    ReleaseDate = DateTime.Parse("2007-5-4"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
              Title = "Koto Aye ",
                    ReleaseDate = DateTime.Parse("2003-3-1"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Great Gatsby",
                    ReleaseDate = DateTime.Parse("2013-5-10"),
                    Genre = "Romance",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio",
                    ReleaseDate = DateTime.Parse("2011-5-15"),
                    Genre = "comedy",
                    Rating = "R",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}