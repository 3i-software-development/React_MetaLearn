using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("COMPANY_RULE_ITEM")]
public partial class CompanyRuleItem
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(50)]
    public string ItemCode { get; set; }

    [Column("ITEM")]
    [StringLength(255)]
    public string Item { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("CREATE_TIME", TypeName = "datetime")]
    public DateTime? CreateTime { get; set; }

    [Column("CREATE_BY")]
    [StringLength(50)]
    public string CreateBy { get; set; }

    [Column("UPDATE_TIME", TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(50)]
    public string UpdateBy { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }
}
