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
using MvcMovie.DynamicDisplays;

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

            RaportsDetails style = new RaportsDetails(); 


            string[] badValues =  {"color: gold;","background-color: red;"};

            if(raport.Odczyt1 > produkt.normaHigh || raport.Odczyt1 < produkt.normaLow){
                    style.TxtColor1 = badValues[0];
                    style.BgColor1 = badValues[1];
                    style.NormyPrzekroczone = true;
            }

            if(raport.Odczyt2 > produkt.normaHigh || raport.Odczyt2 < produkt.normaLow){
                    style.TxtColor2 = badValues[0];
                    style.BgColor2 = badValues[1];
                    style.NormyPrzekroczone = true;
            }

            if(raport.Odczyt3 > produkt.normaHigh || raport.Odczyt3 < produkt.normaLow){
                    style.TxtColor3 = badValues[0];
                    style.BgColor3 = badValues[1];
                    style.NormyPrzekroczone = true;
            }

            if(style.NormyPrzekroczone)
            {
                style.StatusNormy = "display: block;";
            }

            SzczegolyRaportu szczegolyRaportu = new SzczegolyRaportu(){
                produkt = produkt,
                raport = raport,
                styl = style
            };
            

            return View(szczegolyRaportu);
        }
    }
}