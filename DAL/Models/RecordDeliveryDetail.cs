using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RECORD_DELIVERY_DETAIL")]
public partial class RecordDeliveryDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("RECORD_CODE")]
    [StringLength(255)]
    public string RecordCode { get; set; }

    [Column("DELIVERY_CODE")]
    [StringLength(255)]
    public string DeliveryCode { get; set; }
}
