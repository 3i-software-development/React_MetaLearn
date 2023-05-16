using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASP_NET_USERS_TEST")]
[Index("NormalizedEmail", Name = "EMAIL_INDEX")]
[Index("AccountExecutiveId", Name = "IX_1366617594")]
[Index("BranchId", Name = "IX_ASP_NET_USERS_BRANCH_ID")]
[Index("NormalizedUserName", Name = "USER_NAME_INDEX", IsUnique = true)]
public partial class AspNetUsersTest
{
    [Key]
    [Column("ID")]
    [StringLength(50)]
    public string Id { get; set; }

    [Column("CONCURRENCY_STAMP")]
    [StringLength(50)]
    public string ConcurrencyStamp { get; set; }

    [Required]
    [Column("USER_NAME")]
    [StringLength(256)]
    public string UserName { get; set; }

    [Required]
    [Column("NORMALIZED_USER_NAME")]
    [StringLength(256)]
    public string NormalizedUserName { get; set; }

    [Column("EMAIL")]
    [StringLength(256)]
    public string Email { get; set; }

    [Column("NORMALIZED_EMAIL")]
    [StringLength(256)]
    public string NormalizedEmail { get; set; }

    [Column("EMAIL_CONFIRMED")]
    public bool EmailConfirmed { get; set; }

    [Column("TWO_FACTOR_ENABLED")]
    public bool TwoFactorEnabled { get; set; }

    [Column("ACCESS_FAILED_COUNT")]
    public int AccessFailedCount { get; set; }

    [Column("LOCKOUT_ENABLED")]
    public bool LockoutEnabled { get; set; }

    [Column("LOCKOUT_END")]
    public DateTime? LockoutEnd { get; set; }

    [Column("SECURITY_STAMP")]
    [StringLength(50)]
    public string SecurityStamp { get; set; }

    [Column("PASSWORD_HASH")]
    [StringLength(2000)]
    public string PasswordHash { get; set; }

    [Column("PHONE_NUMBER")]
    [StringLength(100)]
    public string PhoneNumber { get; set; }

    [Column("PHONE_NUMBER_CONFIRMED")]
    public bool PhoneNumberConfirmed { get; set; }

    [Column("FAMILY_NAME")]
    [StringLength(256)]
    public string FamilyName { get; set; }

    [Column("MIDDLE_NAME")]
    [StringLength(256)]
    public string MiddleName { get; set; }

    [Column("GIVEN_NAME")]
    [StringLength(256)]
    public string GivenName { get; set; }

    [Column("OFFICE_NUMBER", TypeName = "decimal(10, 0)")]
    public decimal? OfficeNumber { get; set; }

    [Column("PICTURE")]
    [StringLength(256)]
    public string Picture { get; set; }

    [Column("ACTIVE")]
    public bool Active { get; set; }

    [Column("EMPLOYEE_CODE")]
    [StringLength(50)]
    public string EmployeeCode { get; set; }

    [Column("BRANCH_ID")]
    [StringLength(50)]
    public string BranchId { get; set; }

    [Column("ACCOUNT_EXECUTIVE_ID")]
    [StringLength(50)]
    public string AccountExecutiveId { get; set; }

    [Column("ORG_REFERENCE")]
    [StringLength(2000)]
    public string OrgReference { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(2000)]
    public string Description { get; set; }

    [Column("NOTE")]
    [StringLength(2000)]
    public string Note { get; set; }

    [Column("REASON")]
    [StringLength(2000)]
    public string Reason { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_DATE")]
    public DateTime? UpdatedDate { get; set; }

    [Column("USER_TYPE")]
    public int? UserType { get; set; }

    [Column("IS_EXCEEDED")]
    public bool IsExceeded { get; set; }

    [Column("GENDER")]
    public bool? Gender { get; set; }

    [Column("IS_CHECKIN")]
    public bool? IsCheckin { get; set; }

    [Column("IS_ONLINE")]
    public int IsOnline { get; set; }

    [Column("AREA")]
    [StringLength(4000)]
    public string Area { get; set; }

    [Column("TYPE_STAFF")]
    public int? TypeStaff { get; set; }

    [Column("TYPE_WORK")]
    [StringLength(100)]
    [Unicode(false)]
    public string TypeWork { get; set; }

    [Column("DEPARTMENT_ID")]
    [StringLength(50)]
    public string DepartmentId { get; set; }

    [Column("ROLE_COMBINATION")]
    [StringLength(2000)]
    public string RoleCombination { get; set; }

    [Column("LOGIN_FAIL_COUNT")]
    public int? LoginFailCount { get; set; }

    [Column("SHIFT_LIST")]
    [StringLength(255)]
    public string ShiftList { get; set; }

    [Column("SIGN_IMAGE")]
    [StringLength(255)]
    public string SignImage { get; set; }

    [Column("SESSION_LOGIN")]
    public string SessionLogin { get; set; }
}
