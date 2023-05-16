using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_TRANSPORTER")]
public partial class VcTransporter
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    public string Code { get; set; }

    [Column("DRIVER_ID")]
    public int? DriverId { get; set; }

    [Column("LICENSE_PLATE")]
    [StringLength(50)]
    public string LicensePlate { get; set; }

    [Column("GENERIC")]
    [StringLength(255)]
    public string Generic { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("ORIGIN")]
    [StringLength(255)]
    public string Origin { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("OWNER_CODE")]
    [StringLength(255)]
    public string OwnerCode { get; set; }

    [Column("NUMBER")]
    public int? Number { get; set; }

    [Column("YEAR_MANUFACTURE")]
    public int? YearManufacture { get; set; }

    [Column("CATEGORY")]
    [StringLength(250)]
    public string Category { get; set; }

    [Column("WEIGHT_ITSELF")]
    public int? WeightItself { get; set; }

    [Column("DESIGN_PAYLOAD")]
    public int? DesignPayload { get; set; }

    [Column("PAYLOAD_PULLED")]
    public int? PayloadPulled { get; set; }

    [Column("PAYLOAD_TOTAL")]
    public int? PayloadTotal { get; set; }

    [Column("SIZE_REGISTRY")]
    [StringLength(100)]
    public string SizeRegistry { get; set; }

    [Column("SIZE_USE")]
    [StringLength(100)]
    public string SizeUse { get; set; }

    [Column("REGISTRY_DURATION")]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistryDuration { get; set; }

    [Column("INSURRANCE_DURATION")]
    [StringLength(20)]
    [Unicode(false)]
    public string InsurranceDuration { get; set; }

    [Column("NOTE")]
    [StringLength(1255)]
    public string Note { get; set; }

    [Column("POSITION_GPS")]
    [StringLength(1000)]
    public string PositionGps { get; set; }

    [Column("POSITION_TEXT")]
    [StringLength(500)]
    public string PositionText { get; set; }

    [Column("SUM_DISTANCE")]
    public int? SumDistance { get; set; }

    [Column("ROMOOC_CODE")]
    [StringLength(500)]
    public string RomoocCode { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("CUSTOM_TYPE")]
    [StringLength(50)]
    public string CustomType { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
