using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("SERVICE_CAT_COST_CONDITION")]
public partial class ServiceCatCostCondition
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("HEADER_CODE")]
    [StringLength(255)]
    public string HeaderCode { get; set; }

    [Column("SERVICE_CAT_CODE")]
    [StringLength(255)]
    public string ServiceCatCode { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("OBJ_FROM_VALUE")]
    [StringLength(255)]
    public string ObjFromValue { get; set; }

    [Column("OBJ_TO_VALUE")]
    [StringLength(255)]
    public string ObjToValue { get; set; }

    [Column("UNIT")]
    [StringLength(100)]
    public string Unit { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("RATE", TypeName = "decimal(18, 2)")]
    public decimal? Rate { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("SERVICE_UNIT")]
    [StringLength(100)]
    public string ServiceUnit { get; set; }
}
