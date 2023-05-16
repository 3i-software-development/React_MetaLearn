using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("HR_EMPLOYEE")]
public partial class HrEmployee
{
    /// <summary>
    /// id - Id
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Họ vs tên - FullName
    /// </summary>
    [Required]
    [Column("fullname")]
    [StringLength(50)]
    public string Fullname { get; set; }

    /// <summary>
    /// Tên thường dùng - NickName
    /// </summary>
    [Column("nickname")]
    [StringLength(50)]
    public string Nickname { get; set; }

    /// <summary>
    /// Giới tính - Gender
    /// </summary>
    [Column("gender")]
    public int? Gender { get; set; }

    /// <summary>
    /// Dân tộc - Nation
    /// </summary>
    [Column("nation")]
    [StringLength(50)]
    public string Nation { get; set; }

    /// <summary>
    /// Tôn giáo - Religion
    /// </summary>
    [Column("religion")]
    [StringLength(50)]
    public string Religion { get; set; }

    /// <summary>
    /// Ngày sinh - Birthday
    /// </summary>
    [Column("birthday")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Nguyên quán - BirthOfPlace
    /// </summary>
    [Column("birthofplace")]
    [StringLength(200)]
    public string Birthofplace { get; set; }

    /// <summary>
    /// Hộ khẩu thường trú - PermanentResidence
    /// </summary>
    [Column("permanentresidence")]
    [StringLength(200)]
    public string Permanentresidence { get; set; }

    /// <summary>
    /// Số điện thoại - Phone
    /// </summary>
    [Column("phone")]
    [StringLength(50)]
    public string Phone { get; set; }

    /// <summary>
    /// Ngày vào đảng - FactionDate
    /// </summary>
    [Column("factiondate", TypeName = "datetime")]
    public DateTime? Factiondate { get; set; }

    /// <summary>
    /// Trình độ văn hóa - EducationalLevel
    /// </summary>
    [Column("educationallevel")]
    [StringLength(50)]
    public string Educationallevel { get; set; }

    /// <summary>
    /// Trình độ ngoại ngử - LanguageLevel
    /// </summary>
    [Column("languagelevel")]
    [StringLength(50)]
    public string Languagelevel { get; set; }

    /// <summary>
    /// Sức khẻo - Health
    /// </summary>
    [Column("health")]
    [StringLength(50)]
    public string Health { get; set; }

    /// <summary>
    /// Chứng minh nhân dân - IdentityCard
    /// </summary>
    [Column("identitycard")]
    [StringLength(12)]
    [Unicode(false)]
    public string Identitycard { get; set; }

    /// <summary>
    /// Ngày cấp chứng minh thư - IdentityCardDate
    /// </summary>
    [Column("identitycarddate")]
    public DateTime? Identitycarddate { get; set; }

    /// <summary>
    /// Nới cấp chứng minh thư - IdentityCardPlace
    /// </summary>
    [Column("identitycardplace")]
    [StringLength(100)]
    public string Identitycardplace { get; set; }

    /// <summary>
    /// Số bảo hiểm xã hội - SocialInsurance
    /// </summary>
    [Column("socialinsurance")]
    [StringLength(50)]
    public string Socialinsurance { get; set; }

    /// <summary>
    /// Ngày cấp bảo hiểm xa hội - SocialInsuranceDate
    /// </summary>
    [Column("socialinsurancedate")]
    public DateTime? Socialinsurancedate { get; set; }

    /// <summary>
    /// Nơi cấp bảo hiểm xã hội - SocialInsurancePlace
    /// </summary>
    [Column("socialinsuranceplace")]
    [StringLength(20)]
    public string Socialinsuranceplace { get; set; }

    /// <summary>
    /// Nhận dạng - Identification
    /// </summary>
    [Column("identification")]
    [StringLength(100)]
    public string Identification { get; set; }

    /// <summary>
    /// Đơn vị - Unit
    /// </summary>
    [Column("unit")]
    [StringLength(50)]
    [Unicode(false)]
    public string Unit { get; set; }

    /// <summary>
    /// Bậc lương - Wage
    /// </summary>
    [Column("wage")]
    [StringLength(20)]
    [Unicode(false)]
    public string Wage { get; set; }

    /// <summary>
    /// Loại lương - SalaryType
    /// </summary>
    [Column("salarytype")]
    [StringLength(50)]
    [Unicode(false)]
    public string Salarytype { get; set; }

    /// <summary>
    /// Nhóm lương - SalaryGroup
    /// </summary>
    [Column("salarygroup")]
    [StringLength(12)]
    [Unicode(false)]
    public string Salarygroup { get; set; }

    /// <summary>
    /// Hệ số lương - SalaryFactor
    /// </summary>
    [Column("salaryfactor")]
    public double? Salaryfactor { get; set; }

    /// <summary>
    /// Trường đào tạo - TrainingSchool
    /// </summary>
    [Column("trainingschool")]
    [StringLength(50)]
    public string Trainingschool { get; set; }

    /// <summary>
    /// Thời gian đào tạo - TrainingTime
    /// </summary>
    [Column("trainingtime")]
    [StringLength(200)]
    public string Trainingtime { get; set; }

    /// <summary>
    ///  TrainingType
    /// </summary>
    [Column("trainingtype")]
    [StringLength(50)]
    public string Trainingtype { get; set; }

    /// <summary>
    /// Ngành học - Disciplines
    /// </summary>
    [Column("disciplines")]
    [StringLength(50)]
    public string Disciplines { get; set; }

    /// <summary>
    /// Chuyên ngành - Specialized
    /// </summary>
    [Column("specialized")]
    [StringLength(50)]
    public string Specialized { get; set; }

    /// <summary>
    /// Id Hình ảnh - Picture
    /// </summary>
    [Column("picture")]
    [StringLength(255)]
    public string Picture { get; set; }

    /// <summary>
    /// Mã số thuế - TaxCode
    /// </summary>
    [Column("taxcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Taxcode { get; set; }

    /// <summary>
    /// Chức vụ - Position
    /// </summary>
    [Column("position")]
    [StringLength(255)]
    public string Position { get; set; }

    /// <summary>
    /// Loại hình nhân viên - EmployeeKind
    /// </summary>
    [Column("employeekind")]
    [StringLength(50)]
    public string Employeekind { get; set; }

    /// <summary>
    /// EmailUser
    /// </summary>
    [Column("emailuser")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailuser { get; set; }

    /// <summary>
    /// EmailPassword
    /// </summary>
    [Column("emailpassword")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailpassword { get; set; }

    /// <summary>
    /// Quốc tịch - Nationlaty
    /// </summary>
    [Column("nationlaty")]
    [StringLength(100)]
    public string Nationlaty { get; set; }

    /// <summary>
    /// Trạng thái - Status
    /// </summary>
    [Column("status")]
    public string Status { get; set; }

    /// <summary>
    /// Kiểu nhân viên - EmployeeType
    /// </summary>
    [Column("employeetype")]
    [StringLength(50)]
    public string Employeetype { get; set; }

    /// <summary>
    /// Ngân hàng - Bank
    /// </summary>
    [Column("bank")]
    [StringLength(100)]
    [Unicode(false)]
    public string Bank { get; set; }

    /// <summary>
    /// Chủ tài khoản - AccountHolder
    /// </summary>
    [Column("accountholder")]
    [StringLength(50)]
    public string Accountholder { get; set; }

    /// <summary>
    /// Nơi mở tài khoản - AccountOpenPlace
    /// </summary>
    [Column("accountopenplace")]
    [StringLength(100)]
    public string Accountopenplace { get; set; }

    /// <summary>
    /// Số tài khoản - AccountNumber
    /// </summary>
    [Column("accountnumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string Accountnumber { get; set; }

    /// <summary>
    /// Tình trạng hôn nhân - MaritalStatus
    /// </summary>
    [Column("maritalstatus")]
    public int? Maritalstatus { get; set; }

    /// <summary>
    /// Trình độ tin học - ComputerSkill
    /// </summary>
    [Column("computerskill")]
    [StringLength(250)]
    public string Computerskill { get; set; }

    /// <summary>
    /// 1: Nhân viên
    /// 2: Giáo viên
    /// 3: Gia sư
    /// 4: Thực tập - EmployeeGroup
    /// </summary>
    [Column("employeegroup")]
    [StringLength(50)]
    public string Employeegroup { get; set; }

    [Column("createtime", TypeName = "datetime")]
    public DateTime? Createtime { get; set; }

    [Column("updatetime", TypeName = "datetime")]
    public DateTime? Updatetime { get; set; }

    [Column("language")]
    [StringLength(10)]
    public string Language { get; set; }

    [Column("flag")]
    public int? Flag { get; set; }

    [Column("create_by")]
    [StringLength(50)]
    public string CreateBy { get; set; }

    [Column("updated_by")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("id_driver")]
    public int? IdDriver { get; set; }

    [Column("company_Code")]
    [StringLength(255)]
    public string CompanyCode { get; set; }

    [Column("employee_code")]
    [StringLength(25)]
    public string EmployeeCode { get; set; }

    [Column("work_from")]
    public DateTime? WorkFrom { get; set; }

    [Column("work_to")]
    public DateTime? WorkTo { get; set; }

    [Column("work_type")]
    [StringLength(50)]
    public string WorkType { get; set; }

    /// <summary>
    /// năm kinh nghiêm
    /// </summary>
    [Column("years_of_exp", TypeName = "decimal(10, 0)")]
    public decimal? YearsOfExp { get; set; }

    [Column("SHIFT_LIST")]
    [StringLength(255)]
    public string ShiftList { get; set; }

    [Column("pay_scale")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayScale { get; set; }

    [Column("pay_range")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayRange { get; set; }

    [Column("pay_coef")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayCoef { get; set; }

    [Column("pay_career")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayCareer { get; set; }

    [Column("pay_title")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayTitle { get; set; }

    [Column("pay_certificate")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayCertificate { get; set; }

    [Column("pay_major")]
    [StringLength(255)]
    [Unicode(false)]
    public string PayMajor { get; set; }

    [Column("insurance_book_number")]
    [StringLength(255)]
    [Unicode(false)]
    public string InsuranceBookNumber { get; set; }

    [Column("salary_book_number")]
    [StringLength(255)]
    [Unicode(false)]
    public string SalaryBookNumber { get; set; }

    [Column("log_Pay_Scale")]
    public string LogPayScale { get; set; }

    [Column("log_Pay_Range")]
    public string LogPayRange { get; set; }

    [Column("log_End_Contract")]
    public string LogEndContract { get; set; }

    [Column("log_Movement")]
    public string LogMovement { get; set; }

    [Column("log_Status")]
    public string LogStatus { get; set; }

    [Column("log_Department")]
    public string LogDepartment { get; set; }

    [Column("log_Position")]
    public string LogPosition { get; set; }

    [Column("salary", TypeName = "decimal(18, 0)")]
    public decimal? Salary { get; set; }

    [Column("not_work_day")]
    public string NotWorkDay { get; set; }

    [Column("order")]
    public int? Order { get; set; }

    [Column("marked_by")]
    [StringLength(255)]
    [Unicode(false)]
    public string MarkedBy { get; set; }

    [Column("marked_time")]
    public DateTime? MarkedTime { get; set; }

    [Column("qr_code_payment")]
    [StringLength(1000)]
    [Unicode(false)]
    public string QrCodePayment { get; set; }
}
