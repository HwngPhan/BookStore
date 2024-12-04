using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>()))
            {
                if (context.Books.Any())    // Check if database contains any books
                {
                    return;     // Database contains books already
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "Bröderna Lejonhjärta",
                        Language = "Swedish",
                        ISBN = "9789129688313",
                        DatePublished = DateTime.Parse("2013-9-26"),
                        Price = 139,
                        Author = "Astrid Lindgren",
                        ImageUrl = "/images/lejonhjärta.jpg"
                    },

                    new Book
                    {
                        Title = "The Fellowship of the Ring",
                        Language = "English",
                        ISBN = "9780261102354",
                        DatePublished = DateTime.Parse("1991-7-4"),
                        Price = 100,
                        Author = "J. R. R. Tolkien",
                        ImageUrl = "/images/lotr.jpg"
                    },

                    new Book
                    {
                        Title = "Mystic River",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("2011-6-1"),
                        Price = 91,
                        Author = "Dennis Lehane",
                        ImageUrl = "/images/mystic-river.jpg"
                    },

                    new Book
                    {
                        Title = "Of Mice and Men",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("1994-1-2"),
                        Price = 166,
                        Author = "John Steinbeck",
                        ImageUrl = "/images/of-mice-and-men.jpg"
                    },

                    new Book
                    {
                        Title = "The Old Man and the Sea",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("1994-8-18"),
                        Price = 84,
                        Author = "Ernest Hemingway",
                        ImageUrl = "/images/old-man-and-the-sea.jpg"
                    },

                    new Book
                    {
                        Title = "The Road",
                        Language = "English",
                        ISBN = "9780307386458",
                        DatePublished = DateTime.Parse("2007-5-1"),
                        Price = 95,
                        Author = "Cormac McCarthy",
                        ImageUrl = "/images/the-road.jpg"
                    },


                    new Book
                    {
                        Title = "The Fellowship of the Ring",
                        Language = "English",
                        ISBN = "9780008376062",
                        DatePublished = DateTime.Parse("1954-7-29"),
                        Price = 207,
                        Author = "J. R. R. Tolkien",
                        ImageUrl = "https://salt.tikicdn.com/cache/750x750/ts/product/11/02/89/10da31c0f1cfc7a54edde3ad52efaea7.jpg.webp"
                    },

                    new Book
                    {
                        Title = "The Two Towers",
                        Language = "English",
                        ISBN = "9780008537784",
                        DatePublished = DateTime.Parse("1954-11-11"),
                        Price = 162,
                        Author = "J. R. R. Tolkien",
                        ImageUrl = "https://salt.tikicdn.com/cache/750x750/ts/product/ea/35/c6/2cc24ee2fa3ef0701919289525356c31.jpg.webp"
                    },

                    new Book
                    {
                        Title = "The Return of the King",
                        Language = "English",
                        ISBN = "9780008537746",
                        DatePublished = DateTime.Parse("1955-10-20"),
                        Price = 181,
                        Author = "J. R. R. Tolkien",
                        ImageUrl = "https://salt.tikicdn.com/cache/750x750/ts/product/75/d8/8b/91c6c3e0e1e053575b0d1d18da4792de.jpg.webp"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
