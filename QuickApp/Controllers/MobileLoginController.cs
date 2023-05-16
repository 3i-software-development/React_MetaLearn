using DAL;
using DAL.Models;
using ESEIM.Models;
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
        public List<LmsCourse> GetListCourseMobile(int Price)
        {
            var query = (from item in _context.LmsCourses
                         where item.Price == Price
                         select new LmsCourse
                         {
                             Price = item.Price,
                             CourseCode = item.CourseCode,
                             CourseName = item.CourseName

                         }).ToList();

            return query;

        }
    }
}
