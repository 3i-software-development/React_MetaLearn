using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROD_PACKAGE_RECEIVED")]
public partial class ProdPackageReceived
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("COIL_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CoilCode { get; set; }

    [Column("SIZE", TypeName = "decimal(18, 2)")]
    public decimal? Size { get; set; }

    [Column("REMAIN", TypeName = "decimal(18, 2)")]
    public decimal? Remain { get; set; }

    [Column("POSITION_IN_STORE")]
    [StringLength(255)]
    public string PositionInStore { get; set; }

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

    [Column("TICKET_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("COIL_RELATIVE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CoilRelative { get; set; }

    [Column("PACK_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackType { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(255)]
    public string ProductQrCode { get; set; }

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("PRODUCT_IMP_TYPE")]
    [StringLength(255)]
    public string ProductImpType { get; set; }

    [Column("UNIT_COIL")]
    [StringLength(255)]
    public string UnitCoil { get; set; }

    [Column("PRODUCT_LOT")]
    [StringLength(255)]
    public string ProductLot { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }
}
