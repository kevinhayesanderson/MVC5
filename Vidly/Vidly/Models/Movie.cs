using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public byte NumberInStock { get; set; }
    }
}