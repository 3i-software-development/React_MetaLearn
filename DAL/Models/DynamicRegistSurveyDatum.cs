using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("DYNAMIC_REGIST_SURVEY_DATA")]
public partial class DynamicRegistSurveyDatum
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SURVEY_CODE")]
    [StringLength(50)]
    public string SurveyCode { get; set; }

    [Column("ATTR_VALUE")]
    public string AttrValue { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }
}
