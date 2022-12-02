using System.ComponentModel.DataAnnotations;

namespace GameReviewApp.Data.Entities
{
    public class User
    {
        [Required]
        [MaxLength(25), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public IList<Review> Reviews { get; set; }
        
        public IFormFile Picture { get; set; }
        [Required]
        public int ToPlayBoardId { get; set; }
        [Required]
        public int DoneBoardId { get; set; }




        
    }
}
