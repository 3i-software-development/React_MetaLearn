using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_ENTITY_MAPPING_ASSET")]
public partial class EdmsEntityMappingAsset
{
    [Key]
    public int Id { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("FLOOR_CODE")]
    [StringLength(255)]
    public string FloorCode { get; set; }

    [Column("LINE_CODE")]
    [StringLength(255)]
    public string LineCode { get; set; }

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }

    [Column("BOX_CODE")]
    [StringLength(255)]
    public string BoxCode { get; set; }
}
