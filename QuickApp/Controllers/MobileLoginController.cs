using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QuickApp.Controllers.MobileLoginController;

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

        public class Course
        {
            public int id { get; set; }
            public string course_code { get; set; }
            public string course_name { get; set; }
            public string course_note { get; set; }
            public string img_cover { get; set; }
            public int duration { get; set; }
            public string unit { get; set; }
            public string status { get; set; }
            public int flag { get; set; }
            public string video_present { get; set; }
            public string file_base { get; set; }
            public int rating { get; set; }
            public string created_by { get; set; }
            public DateTime created_time { get; set; }
            public string updated_by { get; set; }
            public DateTime updated_time { get; set; }
            public bool is_deleted { get; set; }
            public string deleted_by { get; set; }
            public string list_subject { get; set; }
            public bool top_search { get; set; }
            public decimal price { get; set; }
            public string tags { get; set; }
            public string list_video { get; set; }
            public DateTime start_time { get; set; }
            public DateTime end_time { get; set; }
            public int count_lecture { get; set; }
            public string share { get; set; }
            public string list_json_canvas { get; set; }
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

        [HttpPost]
        public int AddCourse([FromBody] LmsCourse lmsCourse)
        {
            var newCourse = new LmsCourse()
            {
                CourseCode = lmsCourse.CourseCode,
                CourseName = lmsCourse.CourseName,
                CourseNote = lmsCourse.CourseNote
            };

            _context.LmsCourses.Add(newCourse);
            _context.SaveChanges();

            return lmsCourse.Id;
        }

        [HttpPut]
        public async Task UpdateCourse(int id, [FromBody] LmsCourse lmsCourse)
        {
            /*var course = await _context.LmsCourses.FindAsync(id);*/

            var updateCourse = new LmsCourse()
            {
                Id = id,
                CourseCode = lmsCourse.CourseCode,
                CourseName = lmsCourse.CourseName,
                CourseNote = lmsCourse.CourseNote
            };

            _context.LmsCourses.Update(updateCourse);
            await _context.SaveChangesAsync();
        }

        [HttpDelete]
        public async Task DeleteCourse(int id)
        {
            var deleteCourse = new LmsCourse()
            {
                Id = id
            };

            _context.LmsCourses.Remove(deleteCourse);
            await _context.SaveChangesAsync();
        }
    }
}
