using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_STORE")]
public partial class MaterialStore
{
    [Key]
    [Column("STORE_ID")]
    public int StoreId { get; set; }

    [Column("STORE_CODE")]
    [StringLength(100)]
    public string StoreCode { get; set; }

    [Column("STORE_NAME")]
    [StringLength(250)]
    public string StoreName { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("LOCATION")]
    [StringLength(250)]
    public string Location { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    public string UserId { get; set; }

    [Column("PROVINCE")]
    public int? Province { get; set; }

    [Column("DISTRICT")]
    public int? District { get; set; }

    [Column("WARD")]
    public int? Ward { get; set; }

    [Column("BRANCH_ID")]
    public int? BranchId { get; set; }

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

    [Column("AREA")]
    [StringLength(255)]
    public string Area { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("EXTEND")]
    [StringLength(255)]
    public string Extend { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("COUNT_FLOOR")]
    public int? CountFloor { get; set; }

    [Column("QR_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string QrCode { get; set; }
}
