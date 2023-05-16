using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRAWLER_DOMAIN_CONFIGURATION")]
public partial class CrawlerDomainConfiguration
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("DOMAIN_NAME")]
    [StringLength(255)]
    public string DomainName { get; set; }

    [Column("DOMAIN_GROUP")]
    [StringLength(255)]
    public string DomainGroup { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }
}
