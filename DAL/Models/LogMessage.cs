using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LOG_MESSAGE")]
public partial class LogMessage
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CHANNEL")]
    [StringLength(255)]
    public string Channel { get; set; }

    [Column("CONTENT")]
    public string Content { get; set; }

    [Column("USER")]
    [StringLength(255)]
    public string User { get; set; }

    [Column("TIME_CHAT")]
    public DateTime? TimeChat { get; set; }

    [Column("IMAGE")]
    [StringLength(1000)]
    public string Image { get; set; }

    [Column("GIVEN_NAME")]
    [StringLength(255)]
    public string GivenName { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GroupCode { get; set; }

    [Column("IS_FILE")]
    public bool? IsFile { get; set; }

    [Column("FILE_ID")]
    public int? FileId { get; set; }

    [Column("URL")]
    [StringLength(255)]
    public string Url { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
