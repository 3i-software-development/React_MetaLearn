using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_VAYXE_TABLE_COST_DETAILS")]
public partial class RmVayxeTableCostDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SERVICE_CODE")]
    [StringLength(100)]
    public string ServiceCode { get; set; }

    [Column("TABLE_ID")]
    public int? TableId { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
