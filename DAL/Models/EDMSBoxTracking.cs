using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_BOX_TRACKING")]
public partial class EdmsBoxTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOX_CODE")]
    [StringLength(255)]
    public string BoxCode { get; set; }

    [Column("ACTION")]
    [StringLength(255)]
    public string Action { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("ACTION_TIME", TypeName = "datetime")]
    public DateTime? ActionTime { get; set; }

    [Column("POSITION_BOX")]
    [StringLength(255)]
    public string PositionBox { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("CREATED_TIME", TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME", TypeName = "datetime")]
    public DateTime? UpdatedTime { get; set; }
}
