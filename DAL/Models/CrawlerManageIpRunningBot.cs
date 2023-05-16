using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CRAWLER_MANAGE_IP_RUNNING_BOT")]
public partial class CrawlerManageIpRunningBot
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ROBOT_CODE")]
    public string RobotCode { get; set; }

    [Column("ROBOT_NAME")]
    public string RobotName { get; set; }

    [Column("IP_COMPUTER", TypeName = "text")]
    public string IpComputer { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    public string Status { get; set; }

    [Column("PORT_COMPUTER")]
    public int? PortComputer { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
