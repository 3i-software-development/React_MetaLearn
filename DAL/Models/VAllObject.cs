using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
public partial class VAllObject
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("CODE")]
    [StringLength(100)]
    public string Code { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(1004)]
    public string Name { get; set; }

    [Required]
    [Column("OBJECT_TYPE")]
    [StringLength(8)]
    [Unicode(false)]
    public string ObjectType { get; set; }
}
