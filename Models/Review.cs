using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public string Reviewer { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public string Comments { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book book { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
