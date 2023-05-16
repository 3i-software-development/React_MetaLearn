using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MAPPING_CONTROLLER_TABLE")]
public partial class MappingControllerTable
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CONTROLLER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Controller { get; set; }

    [Column("ACTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string Action { get; set; }

    [Column("TABLE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Table { get; set; }
}
