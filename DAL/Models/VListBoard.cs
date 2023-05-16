using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VListBoard
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string BoardCode { get; set; }

    [Column("BOARD_NAME")]
    [StringLength(255)]
    public string BoardName { get; set; }
}
