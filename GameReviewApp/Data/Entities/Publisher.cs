using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class Publisher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public IList<Game> Games { get; set; }
    }
}
