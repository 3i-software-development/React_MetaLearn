using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("COMMITMENT_DETAIL")]
public partial class CommitmentDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("COMMITMENT_CODE")]
    [StringLength(255)]
    public string CommitmentCode { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }
}
