using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kurakani_backend.Models
{
    public class MessageStatus
    {
        [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid MessageId { get; set; }
    public Message? Message { get; set; }

    [Required]
    public Guid RecipientId { get; set; }
    public User? Recipient { get; set; }

    public DateTime? DeliveredAt { get; set; }
    public DateTime? SeenAt { get; set; }
    }
}