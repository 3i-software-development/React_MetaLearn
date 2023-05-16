using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ACT_INSTANCE_USER_ACTIVITY")]
public partial class ActInstanceUserActivity
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string UserId { get; set; }

    [Column("ACT_INST_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActInstCode { get; set; }

    [Column("ACTION")]
    [StringLength(100)]
    public string Action { get; set; }

    [Column("IS_CHECK")]
    public bool IsCheck { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(255)]
    public string FromDevice { get; set; }

    [Column("ID_OBJECT")]
    [StringLength(255)]
    public string IdObject { get; set; }

    [Column("CHANGE_DETAILS")]
    public string ChangeDetails { get; set; }

    [Column("LOG")]
    public string Log { get; set; }
}
