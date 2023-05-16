using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_QUIZ_LECTURE_SUBJECT_COURSE")]
public partial class LmsQuizLectureSubjectCourse
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("QUIZ_CODE")]
    [StringLength(100)]
    public string QuizCode { get; set; }

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
