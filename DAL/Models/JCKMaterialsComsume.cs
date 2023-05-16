using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("JCK_MATERIALS_COMSUME")]
public partial class JckMaterialsComsume
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("JCT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string JctCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(100)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
