using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class ExtrefieldValueModel
    {
        public int Id { get; set; }
        public string FieldValue { get; set; }     
        public  int? FieldGroup { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Trash { get; set; }
        public bool? Published { get; set; }
        public int? Ordering { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
        public DateTime? DatePost { get; set; }
    }
    public class BannerSearch
    {
        public string Title { get; set; }
        public int FieldGroup { get; set; }
        public bool? Trash { get; set; }
        public bool? Published { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class BannerOrSliderModel
    {      
        public string Title { get; set; }     
        public string LinkRef{ get; set; }   
        public string Description { get; set; }
        public string Images { get; set; }
        public int Block { get; set; }
    }
    public class VideoModel
    {
        public string Title { get; set; }
        public string LinkRef { get; set; }
        public string Description { get; set; }
        public string Gallery { get; set; }
        public string Video { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? DatePost { get; set; }
        //public int TotalRow { get; set; }
        //public int P { get; set; }
        //public int R { get; set; }

    }
    public class LinkModel
    {
        public string Title { get; set; }
        public string LinkRef { get; set; }     
    }

    public class VideoSearch
    {
        public int? CategoryId { get; set;}
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

    public class VideoM
    {
        public DateTime? DatePost { get; set; }
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public DateTime? Created { get; set; }
        public int? CategoryId { get; set; }
        public VideoModel VideoExtra { get; set; }
        public List<VideoM> ListVideoM { get; set; }
        public int P { get; set; }
        public int R { get; set; }
        public int TotalRow { get; set; }
    }
    public class SliderModel
    {
        public string Title { get; set; }
        public string LinkRef { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
 

    }
    public class SliderM
    {
        public DateTime? DatePost { get; set; }
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public DateTime? Created { get; set; }
        public SliderModel SliderExtra { get; set; }
        public List<SliderM> ListSliderM { get; set; }
        public int P { get; set; }
        public int R { get; set; }
        public int TotalRow { get; set; }
    }
    public class SliderSearch
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }


}
