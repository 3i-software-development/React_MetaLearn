using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LINKED_IN_DATA_PROFILE_USER")]
public partial class LinkedInDataProfileUser
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROFILE_URL")]
    public string ProfileUrl { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("ELEMENT_SITE")]
    public string ElementSite { get; set; }
}
