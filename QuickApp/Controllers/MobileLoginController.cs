using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickApp.Controllers
{
    public class MobileLoginController : Controller
    {

        private readonly ApplicationDbContext _context;

        public MobileLoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public class CourseItem
        {
            public string courseCode { get; set; }
            public decimal? price { get; set; }
            public string courseName { get; set; }
        }

        public List<CourseItem> GetListCourseMobile(int numb)
        {
            var query = (from item in _context.LmsCourses
                         where item.Price == numb
                         select new CourseItem
                         {
                             price = item.Price,
                             courseCode = item.CourseCode,
                             courseName = item.CourseName

                         }).ToList();

            return query;
        }

        
    }
}
