using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VHrEmployee
{
    public int Id { get; set; }

    [Required]
    [Column("fullname")]
    [StringLength(50)]
    public string Fullname { get; set; }

    [Column("nickname")]
    [StringLength(50)]
    public string Nickname { get; set; }

    [Column("gender")]
    public int? Gender { get; set; }

    [Column("nation")]
    [StringLength(50)]
    public string Nation { get; set; }

    [Column("religion")]
    [StringLength(50)]
    public string Religion { get; set; }

    [Column("birthday")]
    public DateTime? Birthday { get; set; }

    [Column("birthofplace")]
    [StringLength(200)]
    public string Birthofplace { get; set; }

    [Column("permanentresidence")]
    [StringLength(200)]
    public string Permanentresidence { get; set; }

    [Column("phone")]
    [StringLength(50)]
    public string Phone { get; set; }

    [Column("factiondate", TypeName = "datetime")]
    public DateTime? Factiondate { get; set; }

    [Column("educationallevel")]
    [StringLength(50)]
    public string Educationallevel { get; set; }

    [Column("languagelevel")]
    [StringLength(50)]
    public string Languagelevel { get; set; }

    [Column("health")]
    [StringLength(50)]
    public string Health { get; set; }

    [Column("identitycard")]
    [StringLength(12)]
    [Unicode(false)]
    public string Identitycard { get; set; }

    [Column("identitycarddate")]
    public DateTime? Identitycarddate { get; set; }

    [Column("identitycardplace")]
    [StringLength(100)]
    public string Identitycardplace { get; set; }

    [Column("socialinsurance")]
    [StringLength(50)]
    public string Socialinsurance { get; set; }

    [Column("socialinsurancedate")]
    public DateTime? Socialinsurancedate { get; set; }

    [Column("socialinsuranceplace")]
    [StringLength(20)]
    public string Socialinsuranceplace { get; set; }

    [Column("identification")]
    [StringLength(100)]
    public string Identification { get; set; }

    [Column("unit")]
    [StringLength(50)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("wage")]
    [StringLength(20)]
    [Unicode(false)]
    public string Wage { get; set; }

    [Column("salarytype")]
    [StringLength(50)]
    [Unicode(false)]
    public string Salarytype { get; set; }

    [Column("salarygroup")]
    [StringLength(12)]
    [Unicode(false)]
    public string Salarygroup { get; set; }

    [Column("salaryfactor")]
    public double? Salaryfactor { get; set; }

    [Column("trainingschool")]
    [StringLength(50)]
    public string Trainingschool { get; set; }

    [Column("trainingtime")]
    [StringLength(200)]
    public string Trainingtime { get; set; }

    [Column("trainingtype")]
    [StringLength(50)]
    public string Trainingtype { get; set; }

    [Column("disciplines")]
    [StringLength(50)]
    public string Disciplines { get; set; }

    [Column("specialized")]
    [StringLength(50)]
    public string Specialized { get; set; }

    [Column("picture")]
    [StringLength(255)]
    public string Picture { get; set; }

    [Column("taxcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Taxcode { get; set; }

    [Column("position")]
    [StringLength(255)]
    public string Position { get; set; }

    [Column("employeekind")]
    [StringLength(50)]
    public string Employeekind { get; set; }

    [Column("emailuser")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailuser { get; set; }

    [Column("emailpassword")]
    [StringLength(100)]
    [Unicode(false)]
    public string Emailpassword { get; set; }

    [Column("nationlaty")]
    [StringLength(100)]
    public string Nationlaty { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("employeetype")]
    [StringLength(50)]
    public string Employeetype { get; set; }

    [Column("bank")]
    [StringLength(100)]
    [Unicode(false)]
    public string Bank { get; set; }

    [Column("accountholder")]
    [StringLength(50)]
    public string Accountholder { get; set; }

    [Column("accountopenplace")]
    [StringLength(100)]
    public string Accountopenplace { get; set; }

    [Column("accountnumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string Accountnumber { get; set; }

    [Column("maritalstatus")]
    public int? Maritalstatus { get; set; }

    [Column("computerskill")]
    [StringLength(250)]
    public string Computerskill { get; set; }

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
}
