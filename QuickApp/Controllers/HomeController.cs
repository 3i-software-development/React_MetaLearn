using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickApp.Controllers
{
    public class HomeController : Controller
    {

        //private readonly IMapper _mapper;
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly ILogger _logger;
        //private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        /*public List<LmsCourse> SelectCousre(int Price)
        {
            var query = (from item in _context.LmsCourses
                         where item.Price == Price
                         select new
                         {
                             Price = item.Price,
                             CourseCode = item.CourseCode,
                             CourseName = item.CourseName,
                         }).ToList();

            return query.ToList();

        }*/
    }
}
