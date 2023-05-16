using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("EMPLOYEE_CERTIFICATE")]
public partial class EmployeeCertificate
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CERT_CODE")]
    [StringLength(255)]
    public string CertCode { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(255)]
    public string EmployeeCode { get; set; }

    [Column("CERT_DATE_LICENSE")]
    public DateTime? CertDateLicense { get; set; }

    [Column("IMG_PATH")]
    [StringLength(255)]
    public string ImgPath { get; set; }

    [Column("NOTED")]
    [StringLength(255)]
    public string Noted { get; set; }

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

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("CERT_NUM")]
    [StringLength(255)]
    public string CertNum { get; set; }

    [Column("CERT_DATE_END")]
    public DateTime? CertDateEnd { get; set; }
}
