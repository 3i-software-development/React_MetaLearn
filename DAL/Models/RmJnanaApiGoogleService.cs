using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_JNANA_API_GOOGLE_SERVICES")]
public partial class RmJnanaApiGoogleService
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(250)]
    public string Description { get; set; }

    [Column("KEY")]
    [StringLength(250)]
    public string Key { get; set; }

    [Column("LIMIT")]
    public int Limit { get; set; }

    [Column("SERVICE_TYPE")]
    [StringLength(50)]
    public string ServiceType { get; set; }
}
