using System.Data;
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

            if(raport == null ){
                return NotFound();
            }

            if(produkt == null)
            {
                return NotFound("W bazie nie ma produktu dla danego raportu!!");
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

        // Get Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null){
                return NotFound();
            }

            var raport = await _context.Raport.FindAsync(id);            
            if(raport == null){
                return NotFound();
            }

            return View(raport);
        }

        //Post Edit
        [HttpPost,ActionName("Edit2"),ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("id,NrRaportu,DataRaportu,Odczyt1,Odczyt2,Odczyt3,TypOdczytu,Seria,NazwaZakladu,Produkt")]Raport raport)
        {
            if(ModelState.IsValid){
                try{
                    _context.Raport.Update(raport);
                    await _context.SaveChangesAsync();

                }catch(DBConcurrencyException){
                    if(RaportExists(raport.id)){
                       return NotFound(); 
                    }else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(raport);
        }

        //Get Delete
        public async Task<IActionResult> Delete(int ? id){

            if(id == null)
            {
                return NotFound();
            }

            var raport = await _context.Raport.FindAsync(id);
            if(raport == null)
            {
                return NotFound();
            }

            return View(raport);
        }

        //Post Delete
        [HttpPost,ValidateAntiForgeryToken,ActionName("Delete2")]
        public async Task<IActionResult> Delete(int id){

            var raport = await _context.Raport.FindAsync(id);
            _context.Raport.Remove(raport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaportExists(int id){
            return _context.Raport.Any(r => r.id == id);
        }
    }
}