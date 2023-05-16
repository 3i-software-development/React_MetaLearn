using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CUSTOMER_REMINDER")]
public partial class CustomerReminder
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CUSTOMER_ID")]
    public int? CustomerId { get; set; }

    [Column("REMINDER_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ReminderCode { get; set; }

    [Column("REMINDER_TIME")]
    public DateTime? ReminderTime { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
