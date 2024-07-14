using System.ComponentModel.DataAnnotations;

namespace Notification_and_Reminder.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; } 
        public string Description { get; set; } = String.Empty;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
