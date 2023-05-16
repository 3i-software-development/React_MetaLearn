using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_FCM")]
public partial class VcFcm
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TOKEN")]
    [StringLength(250)]
    public string Token { get; set; }

    [Required]
    [Column("USER_NAME")]
    [StringLength(50)]
    public string UserName { get; set; }
}
