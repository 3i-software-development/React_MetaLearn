using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_FUNCTION_BACK_UP")]
[Index("ParentCode", Name = "IX_VIB_FUNCTION_PARENT_CODE")]
public partial class AdFunctionBackUp
{
    [Key]
    [Column("FUNCTION_CODE")]
    [StringLength(50)]
    public string FunctionCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("ORD")]
    public int? Ord { get; set; }

    [Column("PARENT_CODE")]
    [StringLength(50)]
    public string ParentCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("FUNCTION_ID")]
    public int FunctionId { get; set; }

    [InverseProperty("ParentCodeNavigation")]
    public virtual ICollection<AdFunctionBackUp> InverseParentCodeNavigation { get; set; } = new List<AdFunctionBackUp>();

    [ForeignKey("ParentCode")]
    [InverseProperty("InverseParentCodeNavigation")]
    public virtual AdFunctionBackUp ParentCodeNavigation { get; set; }
}
