using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CUSTOMER_EXTEND")]
public partial class CustomerExtend
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    /// Extend Id
    /// </summary>
    [Column("ext_code")]
    [StringLength(100)]
    public string ExtCode { get; set; }

    /// <summary>
    /// Customer Id
    /// </summary>
    [Column("customer_id")]
    public int? CustomerId { get; set; }

    /// <summary>
    /// Create Time
    /// </summary>
    [Column("created_time")]
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// Update Time
    /// </summary>
    [Column("updated_time")]
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    [Column("flag")]
    public bool? Flag { get; set; }

    [Column("ext_value")]
    [StringLength(500)]
    public string ExtValue { get; set; }

    [Column("ext_group")]
    [StringLength(255)]
    public string ExtGroup { get; set; }

    [Column("isdeleted")]
    public bool Isdeleted { get; set; }
}
