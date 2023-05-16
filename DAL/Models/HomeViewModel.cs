using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace III.WebApp.Website.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            ListItem = new List<ItemNewModel>();
            ListItemMaxHits=new List<ItemNewModel>();
            ListHomeVieItem=new List<HomeViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool? Published { get; set; }
        public int? Ordering { get; set; }
        public string Images { get; set; }
        public bool? Trash { get; set; }
        public string Language { get; set; }
        public List<ItemNewModel> ListItemHot { get; set; }
        public List<ItemNewModel> ListItemFeatured { get; set; }
        public List<ItemNewModel> ListItem { get; set; }
        public List<ItemNewModel> ListItemMaxHits { get; set; }
        public List<HomeViewModel> ListHomeVieItem { get; set; }
        
    }
}

public class ItemNewModel
{
    public ItemNewModel()
    {
        ListItem = new List<ItemNewModel>();
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Alias { get; set; }
    public int? CatID { get; set; }
    public bool? Published { get; set; }
    public bool? Trash { get; set; }
    public int? Ordering { get; set; }
    public string Gallery { get; set; }
    public string IntroText { get; set; }
    public string Language { get; set; }
    public List<ItemNewModel> ListItem { get; set; }
}
