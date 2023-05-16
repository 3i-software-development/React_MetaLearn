using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_RACK_DOCUMENT")]
public partial class EdmsRackDocument
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

    [Column("R_SIZE")]
    [StringLength(255)]
    public string RSize { get; set; }

    [Column("MATERIAL")]
    [StringLength(255)]
    public string Material { get; set; }

    [Column("CNT_CELL")]
    [StringLength(255)]
    public string CntCell { get; set; }

    [Column("R_STATUS")]
    [StringLength(255)]
    public string RStatus { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("CNT_BOX")]
    public int? CntBox { get; set; }

    [Column("LINE_CODE")]
    [StringLength(255)]
    public string LineCode { get; set; }

    [Column("RACK_NAME")]
    [StringLength(255)]
    public string RackName { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }
}
