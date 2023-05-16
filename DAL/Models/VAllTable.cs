using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAllTable
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Required]
    [Column("TABLE_NAME")]
    [StringLength(128)]
    public string TableName { get; set; }
}
