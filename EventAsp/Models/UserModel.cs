using System.ComponentModel.DataAnnotations;

namespace EventAsp.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<ReviewModel> ReviewList { get; set; }
        public DateTime JoinedOn { get; set; }
    }
}
