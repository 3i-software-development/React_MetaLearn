using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public int? CatID { get; set; }
        public bool? Published { get; set; }
        public string IntroText { get; set; }
        public string FullText { get; set; }
        public string Video { get; set; }
        public string Gallery { get; set; }
        public string ExtraFields { get; set; }
        public string ExtraFieldsSearch { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public int? CheckedOut { get; set; }
        public DateTime? CheckedOutTime { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? PublishUp { get; set; }
        public DateTime? PublishDown { get; set; }
        public bool? Trash { get; set; }
        public int? Access { get; set; }
        public int? Ordering { get; set; }
        public short? Featured { get; set; }
        public int? FeaturedOrdering { get; set; }
        public string ImageCaption { get; set; }
        public string ImageCredits { get; set; }
        public string VideoCaption { get; set; }
        public string VideoCredits { get; set; }
        public int? Hits { get; set; }
        public string Params { get; set; }
        public string MetaDesc { get; set; }
        public string MetaData { get; set; }
        public string MetaKey { get; set; }
        public string Plugins { get; set; }
        public string Language { get; set; }
        public string CatName { get; set; }
        public int? Template { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
        public DateTime? DatePost { get; set; }
    }
    public class ItemSearch
    {
        public string Title { get; set; }
        public int? CatID { get; set; }
        public bool? Trash { get; set; }
        public short? Featured { get; set; }
        public bool? Published { get; set; }
        public int? FeaturedOrder { get; set; }
        public int? CreatedBy { get; set; }
        public string Language { get; set; }
        public int? UserId { get; set; }
        public DateTime? PostFrom { get; set; }
        public DateTime? PostTo { get; set; }
        public DateTime? CreatedFrom { get; set; }
        public DateTime? CreatedTo { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
    public class HanhChinhCongSearch
    {
        public string Title { get; set; }
        public string Maso { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string CoQuanThucHien { get; set; }
        public string LinhVuc { get; set; }
        public string TinhTrang { get; set; }
        public string DoiTuongThucHien { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string PhamViApDung { get; set; }
        public int IsCheck { get; set; }
    }
    public class VanBanSearch
    {
        public string SoKyHieu { get; set; }
        public string TrichYeu { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string LoaiVanBan { get; set; }
        public string LinhVuc { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
    public class ItemSearchModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Key { get; set; }

    }
}
