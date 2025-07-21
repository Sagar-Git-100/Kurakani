using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurakani_backend.Models
{
    public class  Notification
    {
        [Key]
    public Guid NotificationId { get; set; }

    [Required]
    public Guid UserId { get; set; }
    public User? User { get; set; }

    public string Title { get; set; } = default!;
    public string Message { get; set; } = default!;
    public DateTime SentAt { get; set; }
    public bool IsRead { get; set; }
    }
}