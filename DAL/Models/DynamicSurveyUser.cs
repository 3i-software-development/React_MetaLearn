using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("Dynamic_Survey_User")]
public partial class DynamicSurveyUser
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ATTR_GROUP")]
    [StringLength(50)]
    public string AttrGroup { get; set; }

    [Column("TIME_EAT")]
    [StringLength(50)]
    public string TimeEat { get; set; }

    [Column("PRICE")]
    [StringLength(50)]
    public string Price { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("NOTE")]
    [StringLength(100)]
    public string Note { get; set; }
}
