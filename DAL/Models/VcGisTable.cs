using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_GIS_TABLE")]
public partial class VcGisTable
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("NAME")]
    [StringLength(50)]
    public string Name { get; set; }

    [Column("PARENT")]
    [StringLength(50)]
    [Unicode(false)]
    public string Parent { get; set; }

    [Column("TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("NODE_GIS")]
    public string NodeGis { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }
}
