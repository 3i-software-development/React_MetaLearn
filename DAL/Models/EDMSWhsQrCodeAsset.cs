using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WHS_QRCODE_ASSET")]
public partial class EdmsWhsQrcodeAsset
{
    [Key]
    public int Id { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    public string ObjCode { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    public string ObjType { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

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

    [Column("FLAG")]
    public bool Flag { get; set; }

    [Column("PRINT_NUMBER")]
    public int? PrintNumber { get; set; }

    [Column("RACK_POSITION")]
    public int? RackPosition { get; set; }
}
