using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("SET_ICON_2_OBJECT")]
public partial class SetIcon2Object
{
    [Key]
    public int Id { get; set; }

    [Column("ICON_CODE")]
    [StringLength(255)]
    public string IconCode { get; set; }

    [Column("ICON_TITLE")]
    [StringLength(255)]
    public string IconTitle { get; set; }

    [Column("ICON_PATH")]
    [StringLength(255)]
    public string IconPath { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("EXP_FILTER_SQL")]
    [StringLength(255)]
    public string ExpFilterSql { get; set; }
}
