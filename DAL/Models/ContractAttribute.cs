using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_ATTRIBUTE")]
public partial class ContractAttribute
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CONTRACT_ATTRIBUTE_ID")]
    public int ContractAttributeId { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ContractCode { get; set; }

    [Column("CONTRACT_VERSION")]
    public int? ContractVersion { get; set; }

    [Column("ATTR_CODE")]
    [StringLength(100)]
    public string AttrCode { get; set; }

    [Column("ATTR_VALUE")]
    [StringLength(255)]
    public string AttrValue { get; set; }

    [Column("ATTR_GROUP")]
    [StringLength(50)]
    public string AttrGroup { get; set; }

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

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }
}
