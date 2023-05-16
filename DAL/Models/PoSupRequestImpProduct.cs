using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PO_SUP_REQUEST_IMP_PRODUCT")]
public partial class PoSupRequestImpProduct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Mã Po sup
    /// </summary>
    [Column("PO_SUP_CODE")]
    [StringLength(255)]
    public string PoSupCode { get; set; }

    /// <summary>
    /// Mã yêu cầu nhập khẩu
    /// </summary>
    [Column("REQ_CODE")]
    [StringLength(255)]
    public string ReqCode { get; set; }
}
