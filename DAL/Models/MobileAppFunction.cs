using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MOBILE_APP_FUNCTION")]
public partial class MobileAppFunction
{
    [Column("APPLICATION_CODE")]
    [StringLength(50)]
    public string ApplicationCode { get; set; }

    [Column("FUNCTION_CODE")]
    [StringLength(50)]
    public string FunctionCode { get; set; }

    [Key]
    [Column("APP_FUNCTION_ID")]
    public int AppFunctionId { get; set; }
}
