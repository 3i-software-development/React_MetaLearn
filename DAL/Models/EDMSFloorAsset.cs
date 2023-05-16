using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_FLOOR_ASSET")]
public partial class EdmsFloorAsset
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FLOOR_CODE")]
    [StringLength(255)]
    public string FloorCode { get; set; }

    [Column("QR_CODE")]
    public string QrCode { get; set; }

    [Column("AREA_SQUARE")]
    [StringLength(255)]
    public string AreaSquare { get; set; }

    [Column("MAP_DESGIN")]
    public string MapDesgin { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("IMAGE")]
    public string Image { get; set; }

    [Column("CNT_LINE")]
    public int? CntLine { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("MANAGER_ID")]
    [StringLength(255)]
    public string ManagerId { get; set; }

    [Column("FLOOR_NAME")]
    [StringLength(255)]
    public string FloorName { get; set; }

    [Column("TEMPERATURE")]
    [StringLength(255)]
    public string Temperature { get; set; }

    [Column("HUMIDITY")]
    [StringLength(255)]
    public string Humidity { get; set; }

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
}
