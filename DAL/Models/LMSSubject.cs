using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LMS_SUBJECT")]
public partial class LmsSubject
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LMS_SUBJECT_CODE")]
    [StringLength(255)]
    public string LmsSubjectCode { get; set; }

    [Column("LMS_SUBJECT_NAME")]
    [StringLength(255)]
    public string LmsSubjectName { get; set; }

    [Column("LMS_SUBJECT_DESC")]
    [StringLength(255)]
    public string LmsSubjectDesc { get; set; }

    [Column("LMS_SUBJECT_GROUP")]
    [StringLength(255)]
    public string LmsSubjectGroup { get; set; }

    [Column("LMS_SUBJECT_TYPE")]
    [StringLength(255)]
    public string LmsSubjectType { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
