using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("IOT_ANALYSIS_ACTION")]
public partial class IotAnalysisAction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FROM_DATE")]
    public DateTime? FromDate { get; set; }

    [Column("TO_DATE")]
    public DateTime? ToDate { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    [Column("FACE_ID")]
    [StringLength(1)]
    public string FaceId { get; set; }

    [Column("NAME_FACE")]
    [StringLength(255)]
    public string NameFace { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("TOTAL", TypeName = "decimal(18, 0)")]
    public decimal? Total { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("IMAGE1")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image1 { get; set; }

    [Column("IMAGE2")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image2 { get; set; }

    [Column("IMAGE3")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image3 { get; set; }

    [Column("IMAGE4")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image4 { get; set; }
}
