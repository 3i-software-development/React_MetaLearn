using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RM_JNANA_FCM_MESSAGE")]
public partial class RmJnanaFcmMessage
{
    [Key]
    public int Id { get; set; }

    [Column("Create_time")]
    public DateTime? CreateTime { get; set; }

    [StringLength(1000)]
    public string Message { get; set; }

    [StringLength(500)]
    public string Title { get; set; }

    public int Type { get; set; }

    [Column("User_Id")]
    public int UserId { get; set; }
}
