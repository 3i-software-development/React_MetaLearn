using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LOG_CHANGE_DOCUMENT")]
public partial class LogChangeDocument
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    public string UserId { get; set; }

    [Column("LOG_CONTENT")]
    public string LogContent { get; set; }

    [Column("TIME_EDIT")]
    public DateTime? TimeEdit { get; set; }

    [Column("TIME_FINISH")]
    public DateTime? TimeFinish { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("IS_EDITED")]
    public bool? IsEdited { get; set; }

    [Column("FILE_NAME")]
    [StringLength(500)]
    public string FileName { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("FILE_TYPE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileType { get; set; }

    [Column("LOG_TEXT")]
    public string LogText { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }
}
