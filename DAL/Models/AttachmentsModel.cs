using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.WebApp.Domain.Models
{
    public class AttachmentsModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public string TitleAttribute { get; set; }
        public int? Hits { get; set; }
    }
}
