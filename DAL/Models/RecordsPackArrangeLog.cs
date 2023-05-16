using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RECORDS_PACK_ARRANGE_LOG")]
public partial class RecordsPackArrangeLog
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTION")]
    [StringLength(255)]
    public string Action { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("MESSAGE")]
    [StringLength(255)]
    public string Message { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
