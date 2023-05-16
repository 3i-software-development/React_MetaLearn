using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("LMS_USER_CLASS")]
public partial class LmsUserClass
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CLASS_CODE")]
    [StringLength(255)]
    public string ClassCode { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }
}
