using System.ComponentModel.DataAnnotations;

namespace EventAsp.Models
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Reviews { get; set; }
        public int AvrgScore { get; set; }
        public string Socials { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
