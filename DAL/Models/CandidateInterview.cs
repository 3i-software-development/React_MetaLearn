using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CANDIDATE_INTERVIEW")]
public partial class CandidateInterview
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CANDIDATE_CODE")]
    [StringLength(255)]
    public string CandidateCode { get; set; }

    /// <summary>
    /// Ngày tới phỏng vấn
    /// </summary>
    [Column("INTERVIEW_DATE")]
    public DateTime InterviewDate { get; set; }

    /// <summary>
    /// Trạng thái
    /// </summary>
    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    /// <summary>
    /// Có mặt
    /// </summary>
    [Column("IS_PRESENT")]
    public bool? IsPresent { get; set; }
}
