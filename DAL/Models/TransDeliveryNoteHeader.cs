using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("TRANS_DELIVERY_NOTE_HEADER")]
public partial class TransDeliveryNoteHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LN_NO")]
    [StringLength(255)]
    public string LnNo { get; set; }

    [Column("DN_NO")]
    [StringLength(255)]
    public string DnNo { get; set; }

    [Column("DATE")]
    public DateTime? Date { get; set; }

    [Column("CONSIGNEE")]
    [StringLength(255)]
    public string Consignee { get; set; }

    [Column("MEANS")]
    [StringLength(255)]
    public string Means { get; set; }

    [Column("ID_NO")]
    [StringLength(255)]
    public string IdNo { get; set; }

    [Column("ENTER_CARD_NO")]
    [StringLength(255)]
    [Unicode(false)]
    public string EnterCardNo { get; set; }

    [Column("CARRIER_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string CarrierName { get; set; }

    [Column("LOADING_PLACE")]
    [StringLength(255)]
    public string LoadingPlace { get; set; }

    [Column("UNLOADING_PLACE")]
    [StringLength(255)]
    public string UnloadingPlace { get; set; }

    [Column("TIME_IN")]
    public DateTime? TimeIn { get; set; }

    [Column("TIME_OUT")]
    public DateTime? TimeOut { get; set; }

    [Column("HOUR")]
    public float? Hour { get; set; }

    [Column("REASON")]
    [StringLength(255)]
    public string Reason { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("PREPARED_BY_SIGN")]
    [StringLength(255)]
    public string PreparedBySign { get; set; }

    [Column("CARRIER_SIGN")]
    [StringLength(255)]
    public string CarrierSign { get; set; }

    [Column("CONSIGNEE_SIGN")]
    [StringLength(255)]
    public string ConsigneeSign { get; set; }

    [Column("SECURITY_SIGN")]
    [StringLength(255)]
    public string SecuritySign { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
