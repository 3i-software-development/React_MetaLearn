using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CANDIDATE_BASIC")]
public partial class CandidateBasic
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CANDIDATE_CODE")]
    [StringLength(255)]
    public string CandidateCode { get; set; }

    [Column("FULLNAME")]
    [StringLength(255)]
    public string Fullname { get; set; }

    [Column("SEX")]
    public int Sex { get; set; }

    [Column("BIRTHDAY")]
    public DateTime? Birthday { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    [Column("PHONE")]
    [StringLength(50)]
    public string Phone { get; set; }

    [Column("EMAIL")]
    [StringLength(100)]
    public string Email { get; set; }

    [Column("MARRIED")]
    public bool Married { get; set; }

    [Column("SKYPE")]
    [StringLength(255)]
    public string Skype { get; set; }

    [Column("FILE_CV_1")]
    [StringLength(255)]
    public string FileCv1 { get; set; }

    [Column("FILE_CV_2")]
    [StringLength(255)]
    public string FileCv2 { get; set; }

    [Column("FILE_CV_3")]
    [StringLength(255)]
    public string FileCv3 { get; set; }

    [Column("MAIN_SKILL")]
    [StringLength(255)]
    public string MainSkill { get; set; }

    [Column("MAIN_PRACTICE_TIME")]
    [StringLength(255)]
    public string MainPracticeTime { get; set; }

    [Column("SUB_SKILL")]
    [StringLength(255)]
    public string SubSkill { get; set; }

    [Column("SUB_PRACTICE_TIME")]
    [StringLength(255)]
    public string SubPracticeTime { get; set; }

    [Column("LANGUAGE_USE")]
    [StringLength(255)]
    public string LanguageUse { get; set; }

    [Column("ABILITY")]
    [StringLength(255)]
    public string Ability { get; set; }

    [Column("SALARY_HOPE", TypeName = "decimal(18, 0)")]
    public decimal? SalaryHope { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("LAPTOP_INFO")]
    [StringLength(255)]
    public string LaptopInfo { get; set; }

    [Column("SMARTPHONE_INFO")]
    [StringLength(255)]
    public string SmartphoneInfo { get; set; }

    [Column("DATE_QUIT")]
    public DateTime? DateQuit { get; set; }

    [Column("TARGETING")]
    [StringLength(500)]
    public string Targeting { get; set; }

    [Column("CAN_JOIN_DATE")]
    public DateTime? CanJoinDate { get; set; }

    [Column("WORK_PLACE")]
    [StringLength(255)]
    public string WorkPlace { get; set; }

    [Column("WORK_FROM")]
    public DateTime? WorkFrom { get; set; }

    [Column("WORK_TO")]
    public DateTime? WorkTo { get; set; }

    [Column("WORK_TYPE")]
    public int? WorkType { get; set; }

    [Column("APPOINTMENT_TIME")]
    public DateTime? AppointmentTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }
}
