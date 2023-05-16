using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("NUMBER_PHONE_DN")]
public partial class NumberPhoneDn
{
    [Column("HỌ TÊN ")]
    [StringLength(255)]
    public string HọTên { get; set; }

    [Column("CHỨC DANH")]
    [StringLength(255)]
    public string ChứcDanh { get; set; }

    [Column("ĐIỆN THOẠI")]
    [StringLength(255)]
    public string ĐiệnThoại { get; set; }

    [Column("ĐỊA CHỈ ")]
    [StringLength(255)]
    public string ĐịaChỉ { get; set; }

    [Column("TÊN TRƯỜNG")]
    [StringLength(255)]
    public string TênTrường { get; set; }
}
