using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_TRACK_DILIGENCE")]
public partial class LmsTrackDiligence
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("OBJECT_RESULT")]
    public string ObjectResult { get; set; }

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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }
}
