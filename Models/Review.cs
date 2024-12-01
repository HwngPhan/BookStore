using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public float Rating { get; set; }
        public string Comments { get; set; }


        public int BookId { get; set; }
        public Book book { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
