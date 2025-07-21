using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurakani_backend.Models
{
    public class OtpRequest
    {
         [Key]
    public Guid OtpId { get; set; }

    [Phone]
    public string PhoneNumber { get; set; } = default!;
    public string OtpCode { get; set; } = default!;
    public bool IsVerified { get; set; }
    public DateTime RequestedAt { get; set; }
    }
}