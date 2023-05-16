using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_CONTRACT")]
public partial class HrContract
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Created_Time")]
    public DateTime? CreatedTime { get; set; }

    [Column("Updated_Time")]
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// Bảo hiểm
    /// </summary>
    public double? Insuarance { get; set; }

    /// <summary>
    /// Ngày thanh toán
    /// </summary>
    [Column("Dates_of_pay")]
    public DateTime? DatesOfPay { get; set; }

    /// <summary>
    /// Nơi làm việc
    /// </summary>
    [Column("Place_Work")]
    [StringLength(250)]
    public string PlaceWork { get; set; }

    /// <summary>
    /// Thời gian làm việc
    /// </summary>
    [Column("Exp_time_work")]
    [StringLength(250)]
    public string ExpTimeWork { get; set; }

    /// <summary>
    /// Bậc lương
    /// </summary>
    [Column("Salary_Ratio")]
    [StringLength(53)]
    public string SalaryRatio { get; set; }

    /// <summary>
    /// Thanh toán
    /// </summary>
    [StringLength(250)]
    public string Payment { get; set; }

    /// <summary>
    /// Loại hợp đồng
    /// </summary>
    [Column("Contract_Type")]
    [StringLength(50)]
    public string ContractType { get; set; }

    /// <summary>
    /// Người ký
    /// </summary>
    [StringLength(50)]
    public string Signer { get; set; }

    /// <summary>
    /// Mã nhân viên
    /// </summary>
    [Column("Employee_Id")]
    public int EmployeeId { get; set; }

    /// <summary>
    /// Lương
    /// </summary>
    public double? Salary { get; set; }

    [Column("Start_Time")]
    public DateTime? StartTime { get; set; }

    [Column("End_Time")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Ngày cấp sổ lao động
    /// </summary>
    [Column("DATE_OF_LABOR_BOOK")]
    public DateTime? DateOfLaborBook { get; set; }

    /// <summary>
    /// Nơi cấp sổ lao động
    /// </summary>
    [Column("PLACE_LABOR_BOOK")]
    [StringLength(250)]
    public string PlaceLaborBook { get; set; }

    /// <summary>
    /// Nội dung công việc
    /// </summary>
    [Column("Work_Content")]
    [StringLength(250)]
    public string WorkContent { get; set; }

    /// <summary>
    /// Phụ cấp
    /// </summary>
    [StringLength(250)]
    public string Allowance { get; set; }

    [Column("Contract_Code")]
    [StringLength(250)]
    public string ContractCode { get; set; }

    [Column("LABOR_BOOK_CODE")]
    [StringLength(250)]
    public string LaborBookCode { get; set; }

    [StringLength(250)]
    public string File { get; set; }

    /// <summary>
    /// Thỏa thuận khác
    /// </summary>
    [Column("Other_Agree")]
    [StringLength(250)]
    public string OtherAgree { get; set; }

    /// <summary>
    /// Thông tin bảo hiểm
    /// </summary>
    [Column("Info_Insuarance")]
    [StringLength(250)]
    public string InfoInsuarance { get; set; }

    /// <summary>
    /// Thông tin hợp đồng
    /// </summary>
    [Column("Info_Contract")]
    [StringLength(250)]
    public string InfoContract { get; set; }

    /// <summary>
    /// Tiền thưởng
    /// </summary>
    public double? Bonus { get; set; }

    /// <summary>
    /// Công cụ làm việc
    /// </summary>
    [Column("Tools_Work")]
    [StringLength(250)]
    public string ToolsWork { get; set; }

    public int? Active { get; set; }

    /// <summary>
    /// Kiểu tiền
    /// </summary>
    [Column("Type_Money")]
    [StringLength(250)]
    public string TypeMoney { get; set; }

    [Column("Value_time_work")]
    public int? ValueTimeWork { get; set; }

    [Column("Created_By")]
    [StringLength(250)]
    public string CreatedBy { get; set; }

    [Column("Updated_By")]
    [StringLength(250)]
    public string UpdatedBy { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }

    [Column("PAY_SCALE")]
    [StringLength(255)]
    public string PayScale { get; set; }
}
