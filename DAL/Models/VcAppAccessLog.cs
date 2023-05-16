using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_APP_ACCESS_LOG")]
public partial class VcAppAccessLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }

    [Column("PASSWORD")]
    [StringLength(255)]
    public string Password { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("TOKEN")]
    public string Token { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("IMEI")]
    public string Imei { get; set; }
}
