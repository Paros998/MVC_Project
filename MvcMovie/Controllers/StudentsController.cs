using System.Runtime.Intrinsics.X86;
using System.Numerics;
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

        // Get version of index
        public async Task<IActionResult> Index(int AgeRangeX,int AgeRangeY,string UniversityString){

            var students = from s in _context.Student select s;

            if(AgeRangeX >= 1 && AgeRangeX <= 100){
                students = students.Where(s => s.Age >= AgeRangeX);
            }
            if(AgeRangeY >= 1 && AgeRangeY <= 100){
                students = students.Where(s => s.Age <= AgeRangeY);
            }
            if(!String.IsNullOrEmpty(UniversityString)){
                students = students.Where(s => s.University.Contains(UniversityString));
            }

            var filteredStudents = new StudentsFilterModel(){
                Students = await students.ToListAsync(),
                AgeRangeX = AgeRangeX,
                AgeRangeY = AgeRangeY,
                UniversityString = UniversityString
            };

            return View(filteredStudents);
        }


        //Get Details
        public async Task<IActionResult> Details(int? id){
            if(id == null){
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(s => s.StudentId == id);
           
            if(student == null){
                return NotFound();
            }
            return View(student);

        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,StudentName,StudentSurname,Age,Year,Semester,JoinTime,University")] Student student){
            if(ModelState.IsValid){
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        //Get Edit
        public async Task<IActionResult> Edit(int? id){
            if(id == null){
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if(student == null){
                return NotFound();
            }
            return View(student);
        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken,ActionName("Edit2")]
        public async Task<IActionResult> Edit(int id,[Bind("StudentId,StudentName,StudentSurname,Age,Year,Semester,JoinTime,University")] Student student){

            // if(id != student.StudentId){
            //     return NotFound();
            // }

            if(ModelState.IsValid)
            {
                try{
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else{
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null){
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(s => s.StudentId == id);
            if(student == null){
                return NotFound();
            }
            return View(student);
        }

        //Post Delete
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool StudentExists(int id)
        {
            return _context.Student.Any(s => s.StudentId == id);
        }
    }
}