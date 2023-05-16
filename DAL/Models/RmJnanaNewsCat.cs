using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_JNANA_NEWS_CAT")]
public partial class RmJnanaNewsCat
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CAT_CODE")]
    [StringLength(250)]
    public string CatCode { get; set; }

    [Column("CAT_TITLE")]
    [StringLength(1000)]
    public string CatTitle { get; set; }

    [Column("CAT_DESCRIPTION")]
    [StringLength(1000)]
    public string CatDescription { get; set; }

    [Column("CAT_PARENT_CODE")]
    public int? CatParentCode { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("CAT_STATUS")]
    public int CatStatus { get; set; }

    [Column("CAT_AVARTA")]
    [StringLength(1000)]
    public string CatAvarta { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(255)]
    public string CompanyCode { get; set; }
}
