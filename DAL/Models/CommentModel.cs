using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public bool? Published { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public int TotalRow { get; set; }
        public long RowNumber { get; set; }
        public string ItemName { get; set; }
        public DateTime? CreatTime { get; set; }
    }
    public class CommentSearch
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public int? ItemId { get; set; }
        public bool? Published { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }

}
