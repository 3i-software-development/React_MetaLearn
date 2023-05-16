using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("BOT_SOCIAL_MANAGEMENT")]
public partial class BotSocialManagement
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOT_SOCIAL_CODE")]
    [StringLength(50)]
    public string BotSocialCode { get; set; }

    [Column("BOT_SOCIAL_NAME")]
    public string BotSocialName { get; set; }

    [Column("BOT_SOCIAL_TYPE")]
    [StringLength(50)]
    public string BotSocialType { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }

    [Column("PASS_WORD")]
    public string PassWord { get; set; }

    [Column("CREDENTIAL")]
    [StringLength(255)]
    public string Credential { get; set; }

    [Column("TOCKEN")]
    public string Tocken { get; set; }

    [Column("CONDITION_STATEMENT")]
    public string ConditionStatement { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

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
