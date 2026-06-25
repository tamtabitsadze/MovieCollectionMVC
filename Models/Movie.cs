using System.ComponentModel.DataAnnotations;

namespace MovieCollectionMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public double Rating { get; set; }
    }
}