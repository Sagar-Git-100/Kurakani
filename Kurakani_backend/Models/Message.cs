using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kurakani_backend.Enums;

namespace Kurakani_backend.Models
{
    public class Message
    {
        [Key]
    public Guid MessageId { get; set; }

    [Required]
    public Guid SenderId { get; set; }
    public User? Sender { get; set; }

    [Required]
    public Guid ChatId { get; set; }
    public Chat? Chat { get; set; }

    public string? Content { get; set; }

    [Required]
    public MessageType MessageType { get; set; }

    public string? MediaUrl { get; set; }
    public string? ThumbnailUrl { get; set; }

    public DateTime SentAt { get; set; }
    public DateTime? DeliveredAt { get; set; }
    public DateTime? SeenAt { get; set; }

    public MessageStatusType Status { get; set; }

    public Guid? ReplyTo { get; set; }
    public Message? ReplyToMessage { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<MessageStatus>? DeliveryStatus { get; set; }
    public Media? Media { get; set; }
    }
}