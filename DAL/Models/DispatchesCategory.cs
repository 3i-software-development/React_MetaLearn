using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_CATEGORY")]
public partial class DispatchesCategory
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    public string Code { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("TYPE")]
    [StringLength(10)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DOCUMENT_TYPE")]
    [StringLength(255)]
    public string DocumentType { get; set; }

    [Column("NUMBER_CREATOR")]
    public int? NumberCreator { get; set; }

    [Column("DOCUMENT_SYMBOL")]
    [StringLength(255)]
    [Unicode(false)]
    public string DocumentSymbol { get; set; }

    [Column("EXPRIED_PROCESS")]
    public int? ExpriedProcess { get; set; }

    [Column("IS_YEAR_BEFORE")]
    public bool? IsYearBefore { get; set; }

    [Column("YEAR")]
    public int? Year { get; set; }

    [Column("TYPE_M")]
    [StringLength(10)]
    [Unicode(false)]
    public string TypeM { get; set; }
}
