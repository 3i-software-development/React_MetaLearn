using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using III.WebApp.Domain.DbContext;

namespace III.WebApp.Domain.Models
{
    public class SessionBackEnd
    {
        public UserLoginSession UserLoginSession { get; set; }
        public List<CheckPermissionSesion> CheckPer { get; set; }
    }

    public class SessionFrontEnd
    {
        public List<CategorySession> CategorySession { get; set; }
        public List<CategoryRightSession> CategoryRightSession { get; set; }
        //banner sidebarright
        public List<BannerSession> BannerSessions { get; set; }
        public List<BannerSession> BannerSessionsBR { get; set; }
        //banner giua trang chu
        public List<BannerSession> BannerSessionsHC { get; set; }
        //banner cuoi trang chu
        public List<BannerSession> BannerSessionsHBR { get; set; }
        public List<BannerSession> BannerSessionsSBR { get; set; }
        public List<VideoSession> Video { get; set; }
        public List<SliderSession> Slider { get; set; }
        public List<LinkSession> Link { get; set; }
        public SettingFeSession SettingFeSession { get; set; }
    }

    [Serializable]
    public class UserLoginSession
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
    }

    [Serializable]
    public class CategorySession
    {
        public CategorySession()
        {
            ListCategoryChild = new List<CategorySession>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int? ParentId { get; set; }
        public bool? Published { get; set; }
        public int? Ordering { get; set; }
        public string Images { get; set; }
        public bool? Trash { get; set; }
        public string Language { get; set; }
        public List<CategorySession> ListCategoryChild { get; set; }
    }

    [Serializable]
    public class CategoryRightSession
    {
        public CategoryRightSession()
        {
            Listitem = new List<ItemSession>();
            ListCategoryRight = new List<CategoryRightSession>();


        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public List<ItemSession> Listitem { get; set; }
        public List<CategoryRightSession> ListCategoryRight { get; set; }

    }
    [Serializable]
    public class ItemSession
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public int CatId { get; set; }
    }
    [Serializable]
    public class BannerSession
    {
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public BannerOrSliderModel BannerExtra { get; set; }

    }
    [Serializable]
    public class VideoSession
    {
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public DateTime? Created { get; set; }
        public VideoModel VideoExtra { get; set; }
        public DateTime? DatePost { get; set; }
    }
    [Serializable]
    public class SliderSession
    {
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public DateTime? Created { get; set; }
        public SliderModel SliderExtra { get; set; }
        public DateTime? DatePost { get; set; }

    }
    [Serializable]
    public class LinkSession
    {
        public int Id { get; set; }
        public int? Ordering { get; set; }
        public DateTime? Created { get; set; }
        public LinkModel LinkExtra { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }

    }

    [Serializable]
    public class SettingFeSession
    {
        public string ImageLogo { get; set; }
        public string ImageBanner { get; set; }
        public string ImageBackground { get; set; }
        public string FooterText { get; set; }
        public string HotLine { get; set; }
    }

}
public class CheckPermissionSesion
{
    public CheckPermissionSesion()
    {
        ListCheckPermission = new List<CheckPermissionSesion>();
    }

    public int GroupId { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public int FunctionId { get; set; }
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public int Rank { get; set; }

    public bool? Add { get; set; }
    public bool? Edit { get; set; }
    public bool? Delete { get; set; }
    public bool? View { get; set; }
    public bool? Full { get; set; }
    public List<CheckPermissionSesion> ListCheckPermission { get; set; }
}
