using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_VAYXE_ACTIVITY_REQUEST_STATUS_DELIVERY")]
public partial class RmVayxeActivityRequestStatusDelivery
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("IS_DELETED")]
    public int IsDeleted { get; set; }

    [Column("IS_DISABLE")]
    public int IsDisable { get; set; }

    [Column("REQUEST_CODE")]
    [StringLength(255)]
    public string RequestCode { get; set; }

    [Column("STATUS")]
    public int Status { get; set; }

    [Column("UPDATED_BY")]
    public int? UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }
}
