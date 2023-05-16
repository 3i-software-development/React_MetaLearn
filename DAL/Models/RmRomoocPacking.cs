using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_PACKING")]
public partial class RmRomoocPacking
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("GIS_DATA")]
    [StringLength(2000)]
    public string GisData { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("OWNER")]
    [StringLength(255)]
    public string Owner { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("CREATE_BY")]
    public int? CreateBy { get; set; }

    [Column("CREATE_DATE")]
    public DateTime? CreateDate { get; set; }

    [Column("FLAG")]
    public int Flag { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("UPDATE_DATE")]
    public DateTime? UpdateDate { get; set; }

    [Column("ADDRESS")]
    [StringLength(500)]
    public string Address { get; set; }

    [Column("ICON")]
    [StringLength(255)]
    [Unicode(false)]
    public string Icon { get; set; }
}
