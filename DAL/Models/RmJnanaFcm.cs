using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RM_JNANA_FCM")]
public partial class RmJnanaFcm
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Token { get; set; }

    [Column("User_id")]
    public int UserId { get; set; }
}
