using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_COMMAND_ORDER_TRUCK")]
public partial class RmCommandOrderTruck
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("NGAY_DIEU_XE")]
    [StringLength(255)]
    public string NgayDieuXe { get; set; }

    [Column("MA_THEO_DOI")]
    [StringLength(255)]
    public string MaTheoDoi { get; set; }

    [Column("PAYMENT")]
    [StringLength(255)]
    public string Payment { get; set; }

    [Column("SO_LENH")]
    [StringLength(255)]
    public string SoLenh { get; set; }

    [Column("TEN_TAI_XE")]
    [StringLength(255)]
    public string TenTaiXe { get; set; }

    [Column("SO_XE")]
    [StringLength(255)]
    public string SoXe { get; set; }

    [Column("SO_MOOC")]
    [StringLength(255)]
    public string SoMooc { get; set; }

    [Column("HANG")]
    [StringLength(255)]
    public string Hang { get; set; }

    [Column("NOI_LAY")]
    [StringLength(255)]
    public string NoiLay { get; set; }

    [Column("NOI_HA")]
    [StringLength(255)]
    public string NoiHa { get; set; }

    [Column("KHACH_HANG")]
    [StringLength(255)]
    public string KhachHang { get; set; }

    [Column("DIA_CHI")]
    [StringLength(255)]
    public string DiaChi { get; set; }

    [Column("PHUONG_AN")]
    [StringLength(255)]
    public string PhuongAn { get; set; }

    [Column("GHI_CHU")]
    [StringLength(255)]
    public string GhiChu { get; set; }

    [Column("KY_XAC_NHAN")]
    [StringLength(255)]
    public string KyXacNhan { get; set; }

    [Column("SO_CONT")]
    [StringLength(255)]
    public string SoCont { get; set; }

    [Column("NGAY_GIO_DEN")]
    [StringLength(100)]
    public string NgayGioDen { get; set; }

    [Column("NGAY_GIO_DI")]
    [StringLength(100)]
    public string NgayGioDi { get; set; }

    [Column("NEO_MOOC")]
    [StringLength(255)]
    public string NeoMooc { get; set; }

    [Column("CAU_DUONG")]
    [StringLength(255)]
    public string CauDuong { get; set; }

    [Column("VE_CONG")]
    [StringLength(255)]
    public string VeCong { get; set; }

    [Column("PHI_NGOAI")]
    [StringLength(255)]
    public string PhiNgoai { get; set; }

    [Column("NANG_CONT")]
    [StringLength(255)]
    public string NangCont { get; set; }

    [Column("HA_CONT")]
    [StringLength(255)]
    public string HaCont { get; set; }

    [Column("KIEM_HOA")]
    [StringLength(255)]
    public string KiemHoa { get; set; }

    [Column("VE_SINH")]
    [StringLength(255)]
    public string VeSinh { get; set; }

    [Column("LUU_BAI")]
    [StringLength(255)]
    public string LuuBai { get; set; }

    [Column("PT_GIAO_CONT")]
    [StringLength(255)]
    public string PtGiaoCont { get; set; }

    [Column("LUU_RONG")]
    [StringLength(255)]
    public string LuuRong { get; set; }

    [Column("TONG_CONG")]
    [StringLength(255)]
    public string TongCong { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("NOI_XUAT_PHAT")]
    [StringLength(500)]
    public string NoiXuatPhat { get; set; }

    [Column("IS_DELETED")]
    public int? IsDeleted { get; set; }

    [Column("CHI_KHAC")]
    [StringLength(255)]
    public string ChiKhac { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("ACTIVE")]
    [StringLength(255)]
    public string Active { get; set; }

    [Column("COMPANY_CODE")]
    [StringLength(255)]
    public string CompanyCode { get; set; }

    [Column("TRIP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TripCode { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("CONFIRM_TYPE")]
    [StringLength(1)]
    [Unicode(false)]
    public string ConfirmType { get; set; }

    [Column("MUC_DO_UU_TIEN")]
    public int? MucDoUuTien { get; set; }
}
