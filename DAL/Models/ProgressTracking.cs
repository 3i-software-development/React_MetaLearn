using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROGRESS_TRACKING")]
public partial class ProgressTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    public string CardCode { get; set; }

    [Column("PROGRESS", TypeName = "decimal(14, 0)")]
    public decimal? Progress { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
