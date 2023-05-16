using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LINKED_IN_DATA_PROFILE_ID")]
public partial class LinkedInDataProfileId
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("LINKED_IN_URL")]
    public string LinkedInUrl { get; set; }

    [Column("LINKED_IN_PROFILE_ID")]
    public string LinkedInProfileId { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
