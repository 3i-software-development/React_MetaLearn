using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_HR_EMPLOYEE")]
public partial class RmHrEmployee
{
    /// <summary>
    /// id - Id
    /// </summary>
    [Column("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Họ vs tên - FullName
    /// </summary>
    [Required]
    [Column("FULLNAME")]
    [StringLength(50)]
    public string Fullname { get; set; }

    /// <summary>
    /// Tên thường dùng - NickName
    /// </summary>
    [Required]
    [Column("NICKNAME")]
    [StringLength(50)]
    public string Nickname { get; set; }

    /// <summary>
    /// Giới tính - Gender
    /// </summary>
    [Column("GENDER")]
    public int? Gender { get; set; }

    /// <summary>
    /// Dân tộc - Nation
    /// </summary>
    [Column("NATION")]
    [StringLength(50)]
    public string Nation { get; set; }

    /// <summary>
    /// Tôn giáo - Religion
    /// </summary>
    [Column("RELIGION")]
    [StringLength(50)]
    public string Religion { get; set; }

    /// <summary>
    /// Ngày sinh - Birthday
    /// </summary>
    [Column("BIRTHDAY")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Nguyên quán - BirthOfPlace
    /// </summary>
    [Column("BIRTHOFPLACE")]
    [StringLength(200)]
    public string Birthofplace { get; set; }

    /// <summary>
    /// Hộ khẩu thường trú - PermanentResidence
    /// </summary>
    [Column("PERMANENTRESIDENCE")]
    [StringLength(200)]
    public string Permanentresidence { get; set; }

    /// <summary>
    /// Số điện thoại - Phone
    /// </summary>
    [Column("PHONE")]
    [StringLength(50)]
    public string Phone { get; set; }

    /// <summary>
    /// Ngày vào đảng - FactionDate
    /// </summary>
    [Column("FACTIONDATE", TypeName = "datetime")]
    public DateTime? Factiondate { get; set; }

    /// <summary>
    /// Trình độ văn hóa - EducationalLevel
    /// </summary>
    [Column("EDUCATIONALLEVEL")]
    [StringLength(50)]
    public string Educationallevel { get; set; }

    /// <summary>
    /// Trình độ ngoại ngử - LanguageLevel
    /// </summary>
    [Column("LANGUAGELEVEL")]
    [StringLength(50)]
    public string Languagelevel { get; set; }

    /// <summary>
    /// Sức khẻo - Health
    /// </summary>
    [Column("HEALTH")]
    [StringLength(50)]
    public string Health { get; set; }

    /// <summary>
    /// Chứng minh nhân dân - IdentityCard
    /// </summary>
    [Column("IDENTITYCARD")]
    [StringLength(12)]
    [Unicode(false)]
    public string Identitycard { get; set; }

    /// <summary>
    /// Ngày cấp chứng minh thư - IdentityCardDate
    /// </summary>
    [Column("IDENTITYCARDDATE")]
    public DateTime? Identitycarddate { get; set; }

    /// <summary>
    /// Nới cấp chứng minh thư - IdentityCardPlace
    /// </summary>
    [Column("IDENTITYCARDPLACE")]
    [StringLength(20)]
    public string Identitycardplace { get; set; }

    /// <summary>
    /// Số bảo hiểm xã hội - SocialInsurance
    /// </summary>
    [Column("SOCIALINSURANCE")]
    [StringLength(12)]
    [Unicode(false)]
    public string Socialinsurance { get; set; }

    /// <summary>
    /// Ngày cấp bảo hiểm xa hội - SocialInsuranceDate
    /// </summary>
    [Column("SOCIALINSURANCEDATE")]
    public DateTime? Socialinsurancedate { get; set; }

    /// <summary>
    /// Nơi cấp bảo hiểm xã hội - SocialInsurancePlace
    /// </summary>
    [Column("SOCIALINSURANCEPLACE")]
    [StringLength(20)]
    public string Socialinsuranceplace { get; set; }

    /// <summary>
    /// Nhận dạng - Identification
    /// </summary>
    [Column("IDENTIFICATION")]
    [StringLength(100)]
    public string Identification { get; set; }

    /// <summary>
    /// Đơn vị - Unit
    /// </summary>
    [Column("UNIT")]
    public int? Unit { get; set; }

    /// <summary>
    /// Bậc lương - Wage
    /// </summary>
    [Column("WAGE")]
    [StringLength(20)]
    [Unicode(false)]
    public string Wage { get; set; }

    /// <summary>
    /// Loại lương - SalaryType
    /// </summary>
    [Column("SALARYTYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Salarytype { get; set; }

    /// <summary>
    /// Nhóm lương - SalaryGroup
    /// </summary>
    [Column("SALARYGROUP")]
    [StringLength(12)]
    [Unicode(false)]
    public string Salarygroup { get; set; }

    /// <summary>
    /// Hệ số lương - SalaryFactor
    /// </summary>
    [Column("SALARYFACTOR")]
    public double? Salaryfactor { get; set; }

    /// <summary>
    /// Trường đào tạo - TrainingSchool
    /// </summary>
    [Column("TRAININGSCHOOL")]
    [StringLength(50)]
    public string Trainingschool { get; set; }

    /// <summary>
    /// Thời gian đào tạo - TrainingTime
    /// </summary>
    [Column("TRAININGTIME")]
    [StringLength(200)]
    public string Trainingtime { get; set; }

    /// <summary>
    ///  TrainingType
    /// </summary>
    [Column("TRAININGTYPE")]
    [StringLength(50)]
    public string Trainingtype { get; set; }

    /// <summary>
    /// Ngành học - Disciplines
    /// </summary>
    [Column("DISCIPLINES")]
    [StringLength(50)]
    public string Disciplines { get; set; }

    /// <summary>
    /// Chuyên ngành - Specialized
    /// </summary>
    [Column("SPECIALIZED")]
    [StringLength(50)]
    public string Specialized { get; set; }

    /// <summary>
    /// Id Hình ảnh - Picture
    /// </summary>
    [Column("PICTURE")]
    [StringLength(255)]
    public string Picture { get; set; }

    /// <summary>
    /// Mã số thuế - TaxCode
    /// </summary>
    [Column("TAXCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Taxcode { get; set; }

    /// <summary>
    /// Chức vụ - Position
    /// </summary>
    [Column("POSITION")]
    [StringLength(255)]
    public string Position { get; set; }

    /// <summary>
    /// Loại hình nhân viên - EmployeeKind
    /// </summary>
    [Column("EMPLOYEEKIND")]
    public int? Employeekind { get; set; }

    /// <summary>
    /// EmailUser
    /// </summary>
    [Column("EMAILUSER")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailuser { get; set; }

    /// <summary>
    /// EmailPassword
    /// </summary>
    [Column("EMAILPASSWORD")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailpassword { get; set; }

    /// <summary>
    /// Quốc tịch - Nationlaty
    /// </summary>
    [Column("NATIONLATY")]
    [StringLength(100)]
    public string Nationlaty { get; set; }

    /// <summary>
    /// Trạng thái - Status
    /// </summary>
    [Column("STATUS")]
    public int? Status { get; set; }

    /// <summary>
    /// Kiểu nhân viên - EmployeeType
    /// </summary>
    [Column("EMPLOYEETYPE")]
    public int? Employeetype { get; set; }

    /// <summary>
    /// Ngân hàng - Bank
    /// </summary>
    [Column("BANK")]
    [StringLength(100)]
    [Unicode(false)]
    public string Bank { get; set; }

    /// <summary>
    /// Chủ tài khoản - AccountHolder
    /// </summary>
    [Column("ACCOUNTHOLDER")]
    [StringLength(50)]
    public string Accountholder { get; set; }

    /// <summary>
    /// Nơi mở tài khoản - AccountOpenPlace
    /// </summary>
    [Column("ACCOUNTOPENPLACE")]
    [StringLength(100)]
    public string Accountopenplace { get; set; }

    /// <summary>
    /// Số tài khoản - AccountNumber
    /// </summary>
    [Column("ACCOUNTNUMBER")]
    [StringLength(50)]
    [Unicode(false)]
    public string Accountnumber { get; set; }

    /// <summary>
    /// Tình trạng hôn nhân - MaritalStatus
    /// </summary>
    [Column("MARITALSTATUS")]
    public int? Maritalstatus { get; set; }

    /// <summary>
    /// Trình độ tin học - ComputerSkill
    /// </summary>
    [Column("COMPUTERSKILL")]
    [StringLength(250)]
    public string Computerskill { get; set; }

    /// <summary>
    /// 1: Nhân viên
    /// 2: Giáo viên
    /// 3: Gia sư
    /// 4: Thực tập - EmployeeGroup
    /// </summary>
    [Column("EMPLOYEEGROUP")]
    public int? Employeegroup { get; set; }

    [Column("CREATETIME", TypeName = "datetime")]
    public DateTime? Createtime { get; set; }

    [Column("UPDATETIME", TypeName = "datetime")]
    public DateTime? Updatetime { get; set; }

    [Column("LANGUAGE")]
    [StringLength(10)]
    public string Language { get; set; }

    [Column("FLAG")]
    public int? Flag { get; set; }

    [Column("CREATE_BY")]
    public int? CreateBy { get; set; }

    [Column("UPDATED_BY")]
    public int? UpdatedBy { get; set; }

    [Column("ID_DRIVER")]
    public int? IdDriver { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(255)]
    public string CompanyCode { get; set; }
}
