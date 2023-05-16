using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? ExtraFieldsGroup { get; set; }
        public bool? Published { get; set; }
        public int? Access { get; set; }
        public int? Ordering { get; set; }
        public string Images { get; set; }
        public string Params { get; set; }
        public bool? Trash { get; set; }
        public string Plugins { get; set; }
        public string Language { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
        public string ExtraFieldGroupName { get; set; }
        public List<CategoryModel> ListCategory { get; set; }
        public int? Template { get; set; }
    }   
    public class CategorySearch
    {
        public string Name { get; set; }
        public bool? Trash { get; set; }
        public bool? Published { get; set; }
        public string Language { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int? ExtraFieldGroup { get; set; }
    }
}
