using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{   

    public class StudentsController: Controller
    {
        private readonly MvcMovieContext _context;

        public StudentsController(MvcMovieContext context){
            _context = context;
        }

        // Get version
        public async Task<IActionResult> Index(){
            return View(await _context.Student.ToListAsync());
        }

        
    }
}