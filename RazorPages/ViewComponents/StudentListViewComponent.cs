using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using RazorPages.DATA;
using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.ViewComponents
{
    public class StudentListViewComponent:ViewComponent
    {
        private readonly StudentDbContext _context;

        public StudentListViewComponent(StudentDbContext context)
        {
            _context = context;
        }
        public ViewViewComponentResult Invoke(string filter)
        {
            filter = HttpContext.Request.Query["filter"];
            return View(new StudentListViewModel
            {
                Students=_context.Students.Where(s=>s.Name.Contains(filter)).ToList()
            });
        }
    }
}
