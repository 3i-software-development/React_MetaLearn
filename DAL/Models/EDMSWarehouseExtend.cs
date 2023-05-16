using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WAREHOUSE_EXTEND")]
public partial class EdmsWarehouseExtend
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EXT_CODE")]
    [StringLength(100)]
    public string ExtCode { get; set; }

    [Column("WHS_CODE")]
    [StringLength(100)]
    public string WhsCode { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("EXT_VALUE")]
    [StringLength(500)]
    public string ExtValue { get; set; }

    [Column("EXT_GROUP")]
    [StringLength(255)]
    public string ExtGroup { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
