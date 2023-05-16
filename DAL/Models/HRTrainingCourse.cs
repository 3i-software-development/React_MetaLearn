using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("HR_TRAINING_COURSE")]
public partial class HrTrainingCourse
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    [StringLength(250)]
    public string Result { get; set; }

    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    [Column("Start_Time")]
    public DateTime? StartTime { get; set; }

    [Column("End_Time")]
    public DateTime? EndTime { get; set; }

    [Column("Received_Place")]
    [StringLength(250)]
    public string ReceivedPlace { get; set; }

    [Column("Traing_Place")]
    [StringLength(250)]
    public string TraingPlace { get; set; }

    [Column("Certificate_Name")]
    [StringLength(250)]
    public string CertificateName { get; set; }

    [Column("Education_Name")]
    [StringLength(250)]
    public string EducationName { get; set; }

    [Column("Info_Details")]
    [StringLength(250)]
    public string InfoDetails { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }
}
