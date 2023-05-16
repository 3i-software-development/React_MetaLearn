using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_VAYXE_BOOK_CHECKING")]
public partial class RmVayxeBookChecking
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("NUM_CHK")]
    public int? NumChk { get; set; }

    [Column("TITLE_CHK")]
    [StringLength(250)]
    public string TitleChk { get; set; }

    [Column("NOTE")]
    [StringLength(250)]
    public string Note { get; set; }

    [Column("NEXT_CHK_TIME")]
    public DateTime? NextChkTime { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("CLIENT_ID")]
    public int? ClientId { get; set; }

    [Column("LICENSE_PLATE")]
    [StringLength(250)]
    public string LicensePlate { get; set; }

    [Column("APPROVER_ID")]
    public int? ApproverId { get; set; }

    [Column("BOOK_CHK_CODE")]
    [StringLength(250)]
    public string BookChkCode { get; set; }

    [Column("BLOCK_ID")]
    public int? BlockId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("VENDOR_CODE")]
    [StringLength(250)]
    public string VendorCode { get; set; }
}
