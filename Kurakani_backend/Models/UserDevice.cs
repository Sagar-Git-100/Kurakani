using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kurakani_backend.Enums;


namespace Kurakani_backend.Models
{
    public class UserDevice
    {
        [Key]
    public Guid DeviceId { get; set; }

    [Required]
    public Guid UserId { get; set; }
    public User? User { get; set; }

    public string DeviceToken { get; set; } = default!;
    public PlatformType Platform { get; set; }
    public DateTime LastActive { get; set; }
    public bool IsLoggedIn { get; set; }
    }
}