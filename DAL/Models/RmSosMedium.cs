using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("RM_SOS_MEDIA")]
public partial class RmSosMedium
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column("PATH")]
    [StringLength(100)]
    [Unicode(false)]
    public string Path { get; set; }

    [Column("EXTENSION")]
    [StringLength(100)]
    [Unicode(false)]
    public string Extension { get; set; }

    [Column("SIZE")]
    public double? Size { get; set; }

    [Column("SOS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SosCode { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("IMAGE_BINARY", TypeName = "image")]
    public byte[] ImageBinary { get; set; }
}
