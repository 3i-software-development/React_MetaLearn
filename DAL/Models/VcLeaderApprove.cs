using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VC_LEADER_APPROVE")]
public partial class VcLeaderApprove
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("WP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string WpCode { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }
}
