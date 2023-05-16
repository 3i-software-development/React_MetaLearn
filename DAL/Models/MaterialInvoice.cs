using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_INVOICE")]
public partial class MaterialInvoice
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("TITLE")]
    [StringLength(250)]
    public string Title { get; set; }

    [Column("TOTAL_PAY")]
    public double? TotalPay { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    public string Currency { get; set; }

    [Column("TYPE")]
    public int? Type { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("CONTRACT_ID")]
    public int? ContractId { get; set; }

    [Column("REASON")]
    public int? Reason { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
