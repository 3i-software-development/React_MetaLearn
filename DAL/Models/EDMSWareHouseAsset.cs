using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WAREHOUSE_ASSET")]
public partial class EdmsWarehouseAsset
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

    [Column("WHS_NAME")]
    [StringLength(255)]
    public string WhsName { get; set; }

    [Column("WHS_NOTE")]
    public string WhsNote { get; set; }

    [Column("WHS_AREA_SQUARE")]
    [StringLength(255)]
    public string WhsAreaSquare { get; set; }

    [Column("WHS_CNT_FLOOR")]
    public int? WhsCntFloor { get; set; }

    [Column("WHS_ADDR_TEXT")]
    [StringLength(255)]
    public string WhsAddrText { get; set; }

    [Column("WHS_ADDR_GPS")]
    [StringLength(255)]
    public string WhsAddrGps { get; set; }

    [Column("WHS_AVATAR")]
    [StringLength(255)]
    public string WhsAvatar { get; set; }

    [Column("IMG_WHS")]
    [StringLength(255)]
    public string ImgWhs { get; set; }

    [Column("WHS_TAGS")]
    [StringLength(500)]
    public string WhsTags { get; set; }

    [Column("WHS_DESGIN_MAP")]
    [StringLength(255)]
    public string WhsDesginMap { get; set; }

    [Column("WHS_STATUS")]
    [StringLength(255)]
    public string WhsStatus { get; set; }

    [Column("MANAGER_ID")]
    [StringLength(50)]
    public string ManagerId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("WHS_FLAG")]
    public bool WhsFlag { get; set; }

    /// <summary>
    /// PRODUCT(PR), RECORD_VOUCHER (RV)
    /// </summary>
    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }
}
