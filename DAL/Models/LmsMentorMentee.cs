using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_MENTOR_MENTEE")]
public partial class LmsMentorMentee
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MENTOR_CODE")]
    [StringLength(50)]
    public string MentorCode { get; set; }

    [Column("MENTEE_CODE")]
    public string MenteeCode { get; set; }

    [Column("UPDATED_DATE")]
    [Precision(6)]
    public DateTime? UpdatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(45)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    [Precision(6)]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
