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
                    // new Book
                    // {
                    //     Title = "Bröderna Lejonhjärta",
                    //     Language = "Swedish",
                    //     ISBN = "9789129688313",
                    //     DatePublished = DateTime.Parse("2013-9-26"),
                    //     Price = 139,
                    //     Author = "Astrid Lindgren",
                    //     ImageUrl = "/images/lejonhjärta.jpg"
                    // },

                    // new Book
                    // {
                    //     Title = "The Fellowship of the Ring",
                    //     Language = "English",
                    //     ISBN = "9780261102354",
                    //     DatePublished = DateTime.Parse("1991-7-4"),
                    //     Price = 100,
                    //     Author = "J. R. R. Tolkien",
                    //     ImageUrl = "/images/lotr.jpg"
                    // },

                    // new Book
                    // {
                    //     Title = "Mystic River",
                    //     Language = "English",
                    //     ISBN = "9780062068408",
                    //     DatePublished = DateTime.Parse("2011-6-1"),
                    //     Price = 91,
                    //     Author = "Dennis Lehane",
                    //     ImageUrl = "/images/mystic-river.jpg"
                    // },

                    // new Book
                    // {
                    //     Title = "Of Mice and Men",
                    //     Language = "English",
                    //     ISBN = "9780062068408",
                    //     DatePublished = DateTime.Parse("1994-1-2"),
                    //     Price = 166,
                    //     Author = "John Steinbeck",
                    //     ImageUrl = "/images/of-mice-and-men.jpg"
                    // },

                    // new Book
                    // {
                    //     Title = "The Old Man and the Sea",
                    //     Language = "English",
                    //     ISBN = "9780062068408",
                    //     DatePublished = DateTime.Parse("1994-8-18"),
                    //     Price = 84,
                    //     Author = "Ernest Hemingway",
                    //     ImageUrl = "/images/old-man-and-the-sea.jpg"
                    // },

                    // new Book
                    // {
                    //     Title = "The Road",
                    //     Language = "English",
                    //     ISBN = "9780307386458",
                    //     DatePublished = DateTime.Parse("2007-5-1"),
                    //     Price = 95,
                    //     Author = "Cormac McCarthy",
                    //     ImageUrl = "/images/the-road.jpg"
                    // },
                    
                    new Book
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        Language = "English",
                        ISBN = "9781338878929",
                        DatePublished = DateTime.Parse("1998-9-1"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp1.jpg"
                    },
                    new Book
                    {
                        Title = "Harry Potter and the Chamber of Secrets",
                        Language = "English",
                        ISBN = "9781338878936",
                        DatePublished = DateTime.Parse("2023-5-2"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp2.jpg"
                    },
                    
                    new Book
                    {
                        Title = "Harry Potter and the Prisoner of Azkaban",
                        Language = "English",
                        ISBN = "9781338878943",
                        DatePublished = DateTime.Parse("2001-10-1"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp3.jpg"
                    },
                    
                    new Book
                    {
                        Title = "Harry Potter and the Goblet of Fire",
                        Language = "English",
                        ISBN = "9781338878950",
                        DatePublished = DateTime.Parse("2002-9-1"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp4.jpg"
                    }
                    
                    new Book
                    {
                        Title = "Harry Potter and the Order of the Phoenix",
                        Language = "English",
                        ISBN = "9781338878967",
                        DatePublished = DateTime.Parse("2023-5-2"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp5.jpg"
                    },
                    
                    new Book
                    {
                        Title = "Harry Potter and the Half-Blood Prince",
                        Language = "English",
                        ISBN = "9781338878974",
                        DatePublished = DateTime.Parse("2006-7-25"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp6.jpg"
                    },
                    
                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        Language = "English",
                        ISBN = "9781338878981",
                        DatePublished = DateTime.Parse("2023-5-2"),
                        Price = 250,
                        Author = "J.K. Rowling",
                        ImageUrl = "/images/hp7.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
