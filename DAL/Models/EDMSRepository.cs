using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REPOSITORY")]
public partial class EdmsRepository
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("REPOS_ID")]
    public int ReposId { get; set; }

    [Column("REPOS_CODE")]
    [StringLength(100)]
    public string ReposCode { get; set; }

    [Column("REPOS_NAME")]
    [StringLength(255)]
    public string ReposName { get; set; }

    [Column("ACCOUNT")]
    [StringLength(50)]
    public string Account { get; set; }

    [Column("SERVER")]
    [StringLength(255)]
    public string Server { get; set; }

    [Column("TOKEN")]
    [StringLength(255)]
    public string Token { get; set; }

    [Column("DESC")]
    [StringLength(500)]
    public string Desc { get; set; }

    [Column("PARENT")]
    [StringLength(100)]
    public string Parent { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DElETED_TIME")]
    public DateTime? DelEtedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("PASS_WORD")]
    [StringLength(255)]
    [Unicode(false)]
    public string PassWord { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }
}
