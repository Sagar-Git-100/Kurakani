using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kurakani_backend.Models
{
    public class ChatParticipant
    {
        [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid ChatId { get; set; }
    public Chat? Chat { get; set; }

    [Required]
    public Guid UserId { get; set; }
    public User? User { get; set; }

    public bool IsAdmin { get; set; }
    public DateTime JoinedAt { get; set; }
    }
}