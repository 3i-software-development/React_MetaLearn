using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("WAREHOUSE_RECORDS_PACK")]
public partial class WarehouseRecordsPack
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PACK_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackCode { get; set; }

    [Column("QR_CODE")]
    [StringLength(1000)]
    public string QrCode { get; set; }

    [Column("PACK_NAME")]
    [StringLength(255)]
    public string PackName { get; set; }

    [Column("PACK_LABEL")]
    [StringLength(255)]
    public string PackLabel { get; set; }

    [Column("PACK_LEVEL")]
    [StringLength(255)]
    public string PackLevel { get; set; }

    [Column("PACK_PARENT")]
    [StringLength(255)]
    public string PackParent { get; set; }

    [Column("PACK_HIERARCHY_PATH")]
    [StringLength(255)]
    public string PackHierarchyPath { get; set; }

    [Column("PACK_ZONE_LOCATION")]
    [StringLength(255)]
    public string PackZoneLocation { get; set; }

    [Column("PACK_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackType { get; set; }

    [Column("PACK_GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackGroup { get; set; }

    [Column("PACK_STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackStatus { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("PACK_QUANTITY")]
    public int? PackQuantity { get; set; }

    [Column("IMPORT_HEADER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ImportHeaderCode { get; set; }
}
