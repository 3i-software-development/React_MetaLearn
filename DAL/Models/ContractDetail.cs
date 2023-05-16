using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_DETAIL")]
public partial class ContractDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CONTRACT_DETAIL_ID")]
    public int ContractDetailId { get; set; }

    [Required]
    [Column("ITEM_CODE")]
    [StringLength(100)]
    public string ItemCode { get; set; }

    [Column("ITEM_NAME")]
    [StringLength(255)]
    public string ItemName { get; set; }

    [Column("QUATITY", TypeName = "decimal(18, 5)")]
    public decimal Quatity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("COST", TypeName = "decimal(18, 5)")]
    public decimal Cost { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("CONTRACT_VERSION")]
    public int? ContractVersion { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
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
