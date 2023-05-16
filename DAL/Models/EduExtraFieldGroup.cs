using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDU_EXTRA_FIELD_GROUP")]
public partial class EduExtraFieldGroup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Group { get; set; }
}
