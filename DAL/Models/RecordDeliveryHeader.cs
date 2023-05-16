using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RECORD_DELIVERY_HEADER")]
public partial class RecordDeliveryHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DELIVERY_CODE")]
    [StringLength(255)]
    public string DeliveryCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DELIVERY_TYPE")]
    [StringLength(255)]
    public string DeliveryType { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }

    [Column("DELIVER_CODE")]
    [StringLength(255)]
    public string DeliverCode { get; set; }

    [Column("RECEIVER_NAME")]
    [StringLength(255)]
    public string ReceiverName { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("EXPERTED_RETURN_DATE")]
    public DateTime? ExpertedReturnDate { get; set; }

    [Column("REAL_RETURN_DATE")]
    public DateTime? RealReturnDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
