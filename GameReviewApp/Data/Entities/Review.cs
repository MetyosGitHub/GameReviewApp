using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class Review
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateOnly DateOnly { get; set; }
        [Required]
        public string UserId { get; init; }
        [Required]
        public decimal Score { get; set; }
        [Required]
        public string DateTime { get; set; }
        
    }
}
