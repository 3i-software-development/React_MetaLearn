using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class ExtraFieldModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public int? Group { get; set; }
        public string GroupName { get; set; }
        public int? Ordering { get; set; }
        public bool? Published { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
    }

    public class ExtraFieldSearch
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Group { get; set; }
        public bool? Published { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class ExtraFieldHanhChinhCongModel
    {
        public string Maso { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string CoQuanThucHien { get; set; }
        public string PhamViApDung { get; set; }
        public string LinhVuc { get; set; }
        public string TinhTrang { get; set; }
        public string DoiTuongThucHien { get; set; }
        public string LinksThamChieu { get; set; }

    }
    public class ExtraFieldVanBanModel
    {
        public string TrichYeu { get; set; }
        public string SoKyHieu { get; set; }
        public DateTime? NgayBanHanh { get; set; }
        public DateTime? NgayCoHieuLuc { get; set; }
        public DateTime? NgayHetHieuLuc { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string LoaiVanBan { get; set; }
        public string NguoiKy { get; set; }
        public string ThayTheVanBan { get; set; }
        public string LinhVuc { get; set; }
    }
}
