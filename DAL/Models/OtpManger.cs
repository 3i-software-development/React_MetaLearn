using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("OTP_MANGER")]
public partial class OtpManger
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Column("OTP")]
    [StringLength(50)]
    [Unicode(false)]
    public string Otp { get; set; }

    [Column("PHONE_NUMBER")]
    [StringLength(50)]
    [Unicode(false)]
    public string PhoneNumber { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
