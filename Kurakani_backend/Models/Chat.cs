using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurakani_backend.Models
{
    public class Chat
    {
         [Key]
    public Guid ChatId { get; set; }

    public bool IsGroup { get; set; } = false;
    public string? GroupName { get; set; }
    public string? GroupDescription { get; set; }
    public string? GroupImageUrl { get; set; }

    public Guid? CreatedBy { get; set; }
    public User? Creator { get; set; }

    public DateTime CreatedAt { get; set; }

    public ICollection<ChatParticipant>? Participants { get; set; }
    public ICollection<Message>? Messages { get; set; }
    }
}