using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_FCM")]
public partial class RmRomoocFcm
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TOKEN")]
    [StringLength(250)]
    public string Token { get; set; }

    [Column("USER_ID")]
    public int UserId { get; set; }
}
