using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_VAYXE_TABLE_COST_HEADER")]
public partial class RmVayxeTableCostHeader
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TABLE_CODE")]
    [StringLength(255)]
    public string TableCode { get; set; }

    [Column("TABLE_NAME")]
    [StringLength(255)]
    public string TableName { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("CREATER_ID")]
    public int? CreaterId { get; set; }

    [Column("APPOVER_ID")]
    [StringLength(255)]
    public string AppoverId { get; set; }

    [Column("BEGIN_TIME_APPLY")]
    public DateTime? BeginTimeApply { get; set; }

    [Column("END_TIME_APPLY")]
    public DateTime? EndTimeApply { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
