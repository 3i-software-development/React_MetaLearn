using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REQUEST_END_BOX")]
public partial class EdmsRequestEndBox
{
    [Key]
    public int Id { get; set; }

    [Column("RQ_CODE")]
    [StringLength(255)]
    public string RqCode { get; set; }

    [Column("BOX_CODE")]
    [StringLength(255)]
    public string BoxCode { get; set; }
}
