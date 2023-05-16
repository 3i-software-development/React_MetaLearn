using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("TEAM")]
public partial class Team
{
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    [Column("TEAM_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TeamCode { get; set; }

    [Column("TEAM_NAME")]
    [StringLength(255)]
    public string TeamName { get; set; }

    [Column("MEMBERS")]
    [StringLength(4000)]
    public string Members { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("LEADER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Leader { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }
}
