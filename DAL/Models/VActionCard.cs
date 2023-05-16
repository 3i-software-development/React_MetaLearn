using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
public partial class VActionCard
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Required]
    [Column("CARD_CODE")]
    [StringLength(100)]
    public string CardCode { get; set; }

    [Column("CARD_NAME")]
    [StringLength(255)]
    public string CardName { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(256)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
