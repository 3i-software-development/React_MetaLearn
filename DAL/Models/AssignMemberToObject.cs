using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSIGN_MEMBER_TO_OBJECT")]
public partial class AssignMemberToObject
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

    [Column("OBJ_ID")]
    [StringLength(255)]
    public string ObjId { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    public string UserId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }
}
