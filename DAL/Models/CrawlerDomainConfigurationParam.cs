﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRAWLER_DOMAIN_CONFIGURATION_PARAM")]
public partial class CrawlerDomainConfigurationParam
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("URL")]
    public string Url { get; set; }

    [Column("DOWNLOAD_FILE")]
    public bool? DownloadFile { get; set; }

    [Column("KEY_WORD")]
    [StringLength(255)]
    public string KeyWord { get; set; }

    [Column("DATA_STORAGE")]
    [StringLength(255)]
    public string DataStorage { get; set; }

    [Column("DOMAIN_ID")]
    public int? DomainId { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
