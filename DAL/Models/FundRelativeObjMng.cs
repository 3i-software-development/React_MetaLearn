using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_RELATIVE_OBJ_MNG")]
public partial class FundRelativeObjMng
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    public string ObjType { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    public string ObjCode { get; set; }

    [Column("TICK_RECPT_PAY_CODE")]
    [StringLength(255)]
    public string TickRecptPayCode { get; set; }

    [Column("RELATIVE")]
    [StringLength(255)]
    public string Relative { get; set; }
}
