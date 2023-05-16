using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("DYNAMIC_REGIST_SURVEY")]
public partial class DynamicRegistSurvey
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SURVEY_CODE")]
    [StringLength(255)]
    public string SurveyCode { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(255)]
    public string GroupCode { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(255)]
    public string GroupName { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("REPEAT")]
    [StringLength(255)]
    public string Repeat { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("PRIORITIZED")]
    [StringLength(255)]
    public string Prioritized { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("IMAGE_COVER")]
    [StringLength(1000)]
    public string ImageCover { get; set; }
}
