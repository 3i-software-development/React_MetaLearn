using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LMS_LECTURE_SUBJECT_COURSE")]
public partial class LmsLectureSubjectCourse
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LECTURE_CODE")]
    [StringLength(255)]
    public string LectureCode { get; set; }

    [Column("SUBJECT_CODE")]
    [StringLength(255)]
    public string SubjectCode { get; set; }

    [Column("COURSE_CODE")]
    [StringLength(255)]
    public string CourseCode { get; set; }
}
