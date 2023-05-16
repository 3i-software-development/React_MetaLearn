using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_LINE")]
public partial class EdmsLine
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LINE_CODE")]
    [StringLength(255)]
    public string LineCode { get; set; }

    [Column("L_POSITION")]
    [StringLength(255)]
    public string LPosition { get; set; }

    [Column("L_SIZE")]
    [StringLength(255)]
    public string LSize { get; set; }

    [Column("L_TEXT")]
    [StringLength(255)]
    public string LText { get; set; }

    [Column("CNT_RACK")]
    public int? CntRack { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("FLOOR_CODE")]
    [StringLength(255)]
    public string FloorCode { get; set; }

    [Column("L_COLOR")]
    [StringLength(255)]
    public string LColor { get; set; }

    [Column("L_STATUS")]
    [StringLength(255)]
    public string LStatus { get; set; }

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

    [Column("SHAPE_DATA")]
    public string ShapeData { get; set; }
}
