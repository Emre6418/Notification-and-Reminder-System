using System.ComponentModel.DataAnnotations;

namespace Notification_and_Reminder.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Status { get; set; }
        public int AssignedTo { get; set; }
        public int ProjectId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
