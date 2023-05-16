using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OPERATION_ONLINE_SUPPORT")]
public partial class OperationOnlineSupport
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Column("PASS_WORD")]
    [StringLength(255)]
    [Unicode(false)]
    public string PassWord { get; set; }

    [Column("TITLE_NAME")]
    [StringLength(255)]
    public string TitleName { get; set; }

    [Column("USER_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserType { get; set; }

    [Column("LAST_CALL_TIME")]
    public DateTime? LastCallTime { get; set; }

    [Column("LOCATION_CALL")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationCall { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(1)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
