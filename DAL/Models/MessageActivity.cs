using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MESSAGE_ACTIVITY")]
public partial class MessageActivity
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER")]
    [StringLength(255)]
    [Unicode(false)]
    public string User { get; set; }

    [Column("ACT_FROM")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActFrom { get; set; }

    [Column("ACT_TO")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActTo { get; set; }

    [Column("COMMAND")]
    [StringLength(255)]
    [Unicode(false)]
    public string Command { get; set; }

    [Column("COMMAND_TIME")]
    public DateTime? CommandTime { get; set; }

    [Column("CONFIRM")]
    [StringLength(255)]
    [Unicode(false)]
    public string Confirm { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("CONFIRMED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string ConfirmedBy { get; set; }
}
