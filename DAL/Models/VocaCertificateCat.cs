using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("VOCA_CERTIFICATE_CAT")]
public partial class VocaCertificateCat
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CERT_CODE")]
    [StringLength(100)]
    public string CertCode { get; set; }

    [Column("CERT_NAME")]
    [StringLength(255)]
    public string CertName { get; set; }

    [Column("CERT_LEVEL")]
    [StringLength(255)]
    public string CertLevel { get; set; }

    [Column("CERT_TYPE")]
    [StringLength(255)]
    public string CertType { get; set; }

    [Column("CERT_TERM")]
    public int? CertTerm { get; set; }

    [Column("TERM_UNIT")]
    [StringLength(255)]
    public string TermUnit { get; set; }

    [Column("CERT_NOTE")]
    [StringLength(255)]
    public string CertNote { get; set; }

    [Column("CERT_PARENT")]
    [StringLength(255)]
    public string CertParent { get; set; }

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
}
