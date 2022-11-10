using System.ComponentModel.DataAnnotations;

namespace EventAsp.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime PostedOn { get; set; }
        public EventModel Event { get; set; }
        public int Score { get; set; }
        public string TextContent { get; set; }
    }
}
