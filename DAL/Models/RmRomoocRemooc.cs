using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("RM_ROMOOC_REMOOC")]
public partial class RmRomoocRemooc
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("BARCODE")]
    [StringLength(255)]
    public string Barcode { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    public string Code { get; set; }

    [Column("DATE_OF_ENTRY")]
    public DateTime? DateOfEntry { get; set; }

    [Column("DATE_OF_USE")]
    public DateTime? DateOfUse { get; set; }

    [Column("EXTRAFIELD")]
    public int? Extrafield { get; set; }

    [Column("FLAG_DELETE")]
    public int? FlagDelete { get; set; }

    [Column("GENERIC")]
    [StringLength(255)]
    public string Generic { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("ORIGIN")]
    [StringLength(255)]
    public string Origin { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("CREATE_DATE")]
    public DateTime? CreateDate { get; set; }

    [Column("UPDATE_DATE")]
    public DateTime? UpdateDate { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(50)]
    public string CompanyCode { get; set; }

    [Column("CREATE_BY")]
    public int? CreateBy { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("CONTAINER")]
    [StringLength(255)]
    public string Container { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("NUMBER_TRUCK")]
    public int? NumberTruck { get; set; }

    [Column("OWER_CODE")]
    [StringLength(255)]
    public string OwerCode { get; set; }

    [Column("BRAND")]
    [StringLength(255)]
    public string Brand { get; set; }

    [Column("SELF_WEIGHT")]
    [StringLength(255)]
    public string SelfWeight { get; set; }

    [Column("DESIGN_WEIGHT")]
    [StringLength(255)]
    public string DesignWeight { get; set; }

    [Column("TOTAL_WEIGHT")]
    [StringLength(255)]
    public string TotalWeight { get; set; }

    [Column("NUMBER")]
    [StringLength(255)]
    public string Number { get; set; }

    [Column("SIZE")]
    [StringLength(255)]
    public string Size { get; set; }

    [Column("CURENT_SIZE")]
    [StringLength(255)]
    public string CurentSize { get; set; }

    [Column("DAY_REGISTRY")]
    public DateTime? DayRegistry { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(500)]
    public string Description { get; set; }

    [Column("INTERNAL_CODE")]
    [StringLength(255)]
    public string InternalCode { get; set; }

    [Column("LISENCE_PLATE")]
    [StringLength(255)]
    public string LisencePlate { get; set; }

    [Column("POSITION_GPS")]
    [StringLength(1000)]
    public string PositionGps { get; set; }

    [Column("POSITION_TEXT")]
    [StringLength(500)]
    public string PositionText { get; set; }

    [Column("SUM_DISTANCE")]
    public int? SumDistance { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }
}
