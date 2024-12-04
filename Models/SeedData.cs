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
                    },
                    
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
                    },

                    new Book
                    {
                        Title = "Alice's Adventures In Wonderland",
                        Language = "English",
                        ISBN = "9781398804159",
                        DatePublished = DateTime.Parse("2021-1-1"),
                        Price = 143,
                        Author = "Lewis Carroll",
                        ImageUrl = "https://salt.tikicdn.com/cache/750x750/ts/product/7e/f5/1e/027d247bed982b02de79021df3805379.jpg.webp"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
