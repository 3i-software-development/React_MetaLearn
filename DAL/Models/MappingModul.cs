using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MAPPING_MODUL")]
public partial class MappingModul
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }
}
