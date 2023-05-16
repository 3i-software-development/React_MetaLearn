using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_FCM_MESSAGE")]
public partial class RmRomoocFcmMessage
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("MESSAGE")]
    [StringLength(1000)]
    public string Message { get; set; }

    [Column("TITLE")]
    [StringLength(500)]
    public string Title { get; set; }

    [Column("TYPE")]
    public int Type { get; set; }

    [Column("USER_ID")]
    public int UserId { get; set; }
}
