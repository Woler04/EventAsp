using System.ComponentModel.DataAnnotations;

namespace EventAsp.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
