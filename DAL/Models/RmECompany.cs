using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_E_COMPANY")]
public partial class RmECompany
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("COMPANY_CONTACT")]
    [StringLength(255)]
    public string CompanyContact { get; set; }

    [Column("COMPANY_IMAGE")]
    [StringLength(255)]
    public string CompanyImage { get; set; }

    [Column("COMPANY_NAME")]
    [StringLength(255)]
    public string CompanyName { get; set; }

    [Column("COMPANY_OWNER")]
    [StringLength(255)]
    public string CompanyOwner { get; set; }

    [Column("COMPANY_PHONE")]
    [StringLength(50)]
    public string CompanyPhone { get; set; }

    [Column("COMPANY_TYPE")]
    [StringLength(255)]
    public string CompanyType { get; set; }

    [Column("COMPANY_WEBSITE")]
    [StringLength(255)]
    public string CompanyWebsite { get; set; }

    [Column("CREATE_BY")]
    public int? CreateBy { get; set; }

    [Column("CREATE_DATE")]
    public DateTime? CreateDate { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("FLAG")]
    public int Flag { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("UPDATE_DATE")]
    public DateTime? UpdateDate { get; set; }
}
