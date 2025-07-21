using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kurakani_backend.Models
{
    public class User
    {
        [Key]
    public Guid UserId { get; set; }

    [Phone, Required]
    public string PhoneNumber { get; set; } = default!;

    public string? Name { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public string? About { get; set; }

    public DateTime? LastSeen { get; set; }
    public bool IsOnline { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<ChatParticipant>? ChatParticipants { get; set; }
    public ICollection<Message>? SentMessages { get; set; }
    public ICollection<UserDevice>? Devices { get; set; }
    }
}