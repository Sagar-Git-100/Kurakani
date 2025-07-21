using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kurakani_backend.Models
{
    public class Media
    {
        [Key]
    public Guid MediaId { get; set; }

    public Guid MessageId { get; set; }
    public Message? Message { get; set; }

    public string FileUrl { get; set; } = default!;
    public string FileType { get; set; } = default!;
    public int FileSize { get; set; }

    public DateTime UploadedAt { get; set; }
    }
}