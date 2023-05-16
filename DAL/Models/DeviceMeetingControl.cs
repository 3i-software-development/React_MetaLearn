using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("DEVICE_MEETING_CONTROL")]
public partial class DeviceMeetingControl
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ID_MEETING")]
    [StringLength(50)]
    public string IdMeeting { get; set; }

    [Column("PASSWORD_MEETING")]
    [StringLength(255)]
    public string PasswordMeeting { get; set; }

    [Column("DISPLAY_NAME")]
    [StringLength(50)]
    public string DisplayName { get; set; }

    [Column("DEVICE")]
    [StringLength(50)]
    public string Device { get; set; }

    [Column("DEVICE_TYPE")]
    [StringLength(50)]
    public string DeviceType { get; set; }

    [Column("ONLINE")]
    public bool? Online { get; set; }

    [Column("JOIN_TIME")]
    public DateTime? JoinTime { get; set; }

    [Column("LEAVE_TIME")]
    public DateTime? LeaveTime { get; set; }

    [Column("SDK_KEY")]
    [StringLength(50)]
    public string SdkKey { get; set; }

    [Column("SDK_SECRET")]
    [StringLength(50)]
    public string SdkSecret { get; set; }

    [Column("HOST")]
    [StringLength(50)]
    public string Host { get; set; }
}
