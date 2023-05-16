using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FCM_TOKEN")]
public partial class FcmToken
{
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("TOKEN")]
    public string Token { get; set; }

    [Column("DEVICE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Device { get; set; }

    [Column("APP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AppCode { get; set; }
}
