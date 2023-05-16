using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LINKED_IN_INFO_DATA")]
public partial class LinkedInInfoDatum
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROFILE_URL")]
    public string ProfileUrl { get; set; }

    [Column("NAME")]
    public string Name { get; set; }

    [Column("CONTACT")]
    public string Contact { get; set; }

    [Column("LOCATION")]
    public string Location { get; set; }

    [Column("CURRENT_JOB")]
    public string CurrentJob { get; set; }

    [Column("ABOUT")]
    public string About { get; set; }

    [Column("EXPERIENCE")]
    public string Experience { get; set; }

    [Column("EDUCATION")]
    public string Education { get; set; }

    [Column("SKILL")]
    public string Skill { get; set; }

    [Column("LANGUAGES")]
    public string Languages { get; set; }

    [Column("INTERESTS")]
    public string Interests { get; set; }

    [Column("LICENSES")]
    public string Licenses { get; set; }

    [Column("RECOMMENDATION")]
    public string Recommendation { get; set; }

    [Column("AWARD")]
    public string Award { get; set; }

    [Column("ORGANIZATION")]
    public string Organization { get; set; }

    [Column("ACTIVITY")]
    public string Activity { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("ELEMENT_SITE")]
    public string ElementSite { get; set; }
}
