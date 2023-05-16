using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("lms_course")]
public partial class LmsCourse
{
    [Column("id")]
    public int Id { get; set; }

    [Column("course_code")]
    [StringLength(255)]
    public string CourseCode { get; set; }

    [Column("course_name")]
    [StringLength(255)]
    public string CourseName { get; set; }

    [Column("course_note")]
    public string CourseNote { get; set; }

    [Column("img_cover")]
    [StringLength(255)]
    public string ImgCover { get; set; }

    [Column("duration")]
    public int? Duration { get; set; }

    [Column("unit")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("status")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }

    [Column("video_present")]
    [StringLength(255)]
    public string VideoPresent { get; set; }

    [Column("file_base")]
    [StringLength(255)]
    public string FileBase { get; set; }

    [Column("rating")]
    public int? Rating { get; set; }

    [Column("created_by")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("created_time", TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column("updated_by")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("updated_time", TypeName = "datetime")]
    public DateTime? UpdatedTime { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_by")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("list_subject")]
    public string ListSubject { get; set; }

    [Column("top_search")]
    public bool? TopSearch { get; set; }

    [Column("price", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("tags")]
    public string Tags { get; set; }

    [Column("list_video")]
    public string ListVideo { get; set; }

    [Column("start_time")]
    public DateTime? StartTime { get; set; }

    [Column("end_time")]
    public DateTime? EndTime { get; set; }

    [Column("count_lecture")]
    public int? CountLecture { get; set; }

    [Column("share")]
    public string Share { get; set; }

    [Column("list_json_canvas")]
    public string ListJsonCanvas { get; set; }
}
