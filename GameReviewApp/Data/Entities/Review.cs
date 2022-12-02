using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [Required]
        public decimal Score { get; set; }
        [Required]
        public string DateTime { get; set; }
        
    }
}
