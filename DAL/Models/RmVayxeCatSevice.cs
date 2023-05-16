using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_VAYXE_CAT_SEVICES")]
public partial class RmVayxeCatSevice
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SERVICE_CODE")]
    [StringLength(100)]
    public string ServiceCode { get; set; }

    [Column("SERVICE_NAME")]
    [StringLength(255)]
    public string ServiceName { get; set; }

    [Column("SERVICE_GROUP_ID")]
    [StringLength(50)]
    public string ServiceGroupId { get; set; }

    [Column("SERVICE_TYPE_ID")]
    [StringLength(50)]
    public string ServiceTypeId { get; set; }

    [Column("NOTE")]
    [StringLength(1500)]
    public string Note { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("ILLUSTRATOR_IMG")]
    [StringLength(255)]
    public string IllustratorImg { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
