using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("COMM_ATTRIBUTE")]
public partial class CommAttribute
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("CommID")]
    public int CommId { get; set; }

    [StringLength(100)]
    public string CommCode { get; set; }

    [StringLength(255)]
    public string CommValue { get; set; }

    [StringLength(100)]
    public string CommGroup { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    [StringLength(50)]
    public string DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
