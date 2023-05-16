using DAL;
using Duende.IdentityServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Web;

namespace QuickApp.Controllers
{
    public class PortalController : Controller
    {

        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly ILogger _logger;
        //private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public PortalController(ApplicationDbContext context)
        {
            _context = context;
        }
        public class ItemContent
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Alias { get; set; }

            public int? CatId { get; set; }

            public string IntroText { get; set; }

            public string FullText { get; set; }

            public string Video { get; set; }

            public string Gallery { get; set; }

            public DateTime? Created { get; set; }

            public short? Featured { get; set; }

            public int? Hits { get; set; }

            public string Params { get; set; }

            public int? Template { get; set; }

            public DateTime? DatePost { get; set; }

        }
        public JsonResult ArticleDetail(int itemId)
        {
            var msg = new JMessage() { Error = false };
            try
            {
                var listItem = from a in _context.CmsItems.Where(a => a.Id == itemId)
                               join b in _context.CmsAttachments on itemId equals b.Id
                               select new ItemContent
                               {
                                   Id = a.Id,
                                   Alias = a.Alias,
                                   Params = a.Params,
                                   Title = a.Title,
                                   IntroText = a.IntroText,
                                   Gallery = a.Gallery,
                                   Video = a.Video,
                                   FullText = HttpUtility.HtmlDecode(a.FullText),
                                   Hits = a.Hits,
                                   Template = a.Template,
                                   DatePost = a.DatePost,
                                   Created = a.Created,
                                   Featured = a.Featured,
                                   CatId = a.CatId,
                               };

                msg.Object = listItem;
                msg.Error = false;
            }
            catch (Exception ex)
            {
                msg.Object = ex.Message;
                msg.Error = true;
                msg.Title = "Có lỗi khi lấy dữ liệu";
            }
            return Json(msg);
        }
        public JsonResult ArticleAttachment(int itemId)
        {
            var msg = new JMessage() { Error = false };
            try
            {
                var listItem = (from a in _context.CmsAttachments.Where(a => a.Id == itemId)
                               select new 
                               {
                                   Id = a.Id,
                                   FileName = a.FileName,
                                   Title = a.Title,
                                   TitleAtrr = a.TitleAttribute,
                                   Hits = a.Hits,
                                   FilePath = a.FilePath,
                                   FiltType = a.FileType,
                               }).ToList();

                msg.Object = listItem.ToList();
                msg.Error = false;
            }
            catch (Exception ex)
            {
                msg.Object = ex.Message;
                msg.Error = true;
                msg.Title = "Có lỗi khi lấy dữ liệu";
            }
            return Json(msg);
        }
        public class JMessage
        {
            /// <summary>
            /// ID của bản ghi được thêm, sửa, xóa
            /// </summary>
            public int ID { get; set; }
            /// <summary>
            /// Thông báo
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Có lỗi hay không có lỗi
            /// </summary>
            public bool Error { get; set; }
            /// <summary>
            /// Đối tượng attach kèm theo thông báo
            /// </summary>
            public object Object { get; set; }

            public string Code { get; set; }
            public JMessage(int id, string title, bool error, object obj, string code)
            {
                ID = id; Title = title; Error = error; Object = obj; Code = code;
            }
            public JMessage()
            {

            }
        }
        public JsonResult ArticleRelate( int CatId, int page)
        {
            var msg = new JMessage() { Error = false };
            try
            {
                
                var listItem = (from a in _context.CmsItems.Where(a => a.CatId == CatId)
                            select new ItemContent
                            {
                                Id = a.Id,
                                Alias = a.Alias,
                                Params = a.Params,
                                Title = a.Title,
                                IntroText = a.IntroText,
                                Gallery = a.Gallery,
                                Video = a.Video,
                                Hits = a.Hits,
                                Template = a.Template,
                                DatePost = a.DatePost,
                                Created = a.Created,
                                Featured = a.Featured,
                                CatId = a.CatId,
                            }).ToList().Take(page);
                msg.Object = listItem;
                msg.Error = false;
            }
            catch(Exception ex)
            {
                msg.Object = ex.Message;
                msg.Error = true;
                msg.Title = "Có lỗi khi lấy dữ liệu";
            }
            

            return Json(msg);
        }
        



    }
}
