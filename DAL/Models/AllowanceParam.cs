using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ALLOWANCE_PARAM")]
public partial class AllowanceParam
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("EXCEL_COLUMN")]
    [StringLength(50)]
    [Unicode(false)]
    public string ExcelColumn { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

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

    [Column("BASE")]
    public bool Base { get; set; }

    [Column("DEFAULT_VALUE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DefaultValue { get; set; }
}
