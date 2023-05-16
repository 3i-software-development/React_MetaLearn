using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_MOVE_PRODUCT_LOG")]
public partial class EdmsMoveProductLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    public string ProductCode { get; set; }

    [Column("RACK_CODE_OLD")]
    [StringLength(255)]
    public string RackCodeOld { get; set; }

    [Column("RACK_CODE_NEW")]
    [StringLength(255)]
    public string RackCodeNew { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("LINE_CODE_OLD")]
    [StringLength(255)]
    public string LineCodeOld { get; set; }

    [Column("FLOOR_CODE_OLD")]
    [StringLength(255)]
    public string FloorCodeOld { get; set; }

    [Column("MAPPING_ID")]
    public int? MappingId { get; set; }
}
