using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurakani_backend.Models
{
    public class UserLog
    {
        [Key]
    public Guid LogId { get; set; }

    [Required]
    public Guid UserId { get; set; }
    public User? User { get; set; }

    public string Action { get; set; } = default!;
    public string? Metadata { get; set; }
    public DateTime LoggedAt { get; set; }
    }
}