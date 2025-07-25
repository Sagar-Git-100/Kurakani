using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurakani_backend.DTOs
{
    public class ChatDTO
    {
        public Guid ChatId { get; set; }

    public bool IsGroup { get; set; } = false;
    public string? GroupName { get; set; }
    public string? GroupDescription { get; set; }
    public string? GroupImageUrl { get; set; }

    public Guid? CreatedBy { get; set; }
   

    public DateTime CreatedAt { get; set; }

    }
}