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
    public class RaportsController : Controller
    {
        private readonly MvcMovieContext _context;

        public RaportsController(MvcMovieContext context){
            	_context = context;
        }

        //Get Index

        public async Task<IActionResult> Index(){
            var raporty = await _context.Raport.ToListAsync();
            return View(raporty);
        }

        //Get Details

        public async Task<IActionResult> Details(int? id){

            if(id == null){
                return NotFound();
            }

            var raport = await _context.Raport.FirstOrDefaultAsync(r => r.id == id);
            var produkt = await _context.Produkt.FirstOrDefaultAsync(p => p.typBadania == raport.TypOdczytu && p.nazwa == raport.Produkt);

            if(raport == null || produkt == null){
                return NotFound();
            }

            SzczegolyRaportu szczegolyRaportu = new SzczegolyRaportu(){
                produkt = produkt,
                raport = raport

            };

            return View(szczegolyRaportu);
        }
    }
}