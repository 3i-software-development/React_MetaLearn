using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_CAT_REPT_EXPS")]
public partial class FundCatReptExp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CAT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CatCode { get; set; }

    [Column("CAT_NAME")]
    [StringLength(255)]
    public string CatName { get; set; }

    [Column("CAT_PARENT")]
    [StringLength(255)]
    [Unicode(false)]
    public string CatParent { get; set; }

    [Column("CAT_TYPE")]
    [StringLength(100)]
    public string CatType { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

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
}
