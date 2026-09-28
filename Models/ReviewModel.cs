using System;
using System.ComponentModel.DataAnnotations;

namespace MasterYoga.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Please enter your name or Jedi handle")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string AuthorName { get; set; } = string.Empty;

        public string ForceRank { get; set; } = "Padawan";

        [Required(ErrorMessage = "Please select the session you attended")]
        public string ClassTitle { get; set; } = "Master Yoda Frog Malasana & Hip Mobility";

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars")]
        public int Rating { get; set; } = 5;

        [Required(ErrorMessage = "Please enter a review summary")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Summary must be between 3 and 100 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please share your experience in the comment")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Comment must be between 10 and 1000 characters")]
        public string Comment { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int HelpfulCount { get; set; } = 0;
    }
}
