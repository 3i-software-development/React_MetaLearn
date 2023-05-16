using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("SUPPLIER_EXTEND")]
public partial class SupplierExtend
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ext_code")]
    [StringLength(100)]
    public string ExtCode { get; set; }

    [Column("supplier_code")]
    public int? SupplierCode { get; set; }

    [Column("created_time")]
    public DateTime? CreatedTime { get; set; }

    [Column("updated_time")]
    public DateTime? UpdatedTime { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }

    [Column("ext_value")]
    [StringLength(500)]
    public string ExtValue { get; set; }

    [Column("ext_group")]
    [StringLength(255)]
    public string ExtGroup { get; set; }

    [Column("isdeleted")]
    public bool? Isdeleted { get; set; }
}
