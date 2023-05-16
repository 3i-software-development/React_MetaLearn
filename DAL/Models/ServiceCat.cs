using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("SERVICE_CAT")]
public partial class ServiceCat
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Column("SERVICE_CAT_ID")]
    public int ServiceCatId { get; set; }

    [Column("SERVICE_CODE")]
    [StringLength(100)]
    public string ServiceCode { get; set; }

    [Column("SERVICE_NAME")]
    [StringLength(255)]
    public string ServiceName { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("SERVICE_GROUP")]
    [StringLength(100)]
    public string ServiceGroup { get; set; }

    [Column("SERVICE_TYPE")]
    [StringLength(100)]
    public string ServiceType { get; set; }

    [Column("SERVICE_PARENT")]
    [StringLength(100)]
    public string ServiceParent { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }
}
