using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JeffersonRuiz_Examen1P.Data;
using JeffersonRuiz_Examen1P.Models;

namespace JeffersonRuiz_Examen1P.Controllers
{
    public class JR_tabla1Controller : Controller
    {
        private readonly JeffersonRuiz_Examen1PContext _context;

        public JR_tabla1Controller(JeffersonRuiz_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JR_tabla1
        public async Task<IActionResult> Index()
        {
            return View(await _context.JR_tabla1.ToListAsync());
        }

        // GET: JR_tabla1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jR_tabla1 = await _context.JR_tabla1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jR_tabla1 == null)
            {
                return NotFound();
            }

            return View(jR_tabla1);
        }

        // GET: JR_tabla1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JR_tabla1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JR_Int_Atributo1,JR_String_Atributo2,JR_Booleano_Atributo3,JR_Decimal_Atributo4,JR_Fecha_Atributo5")] JR_tabla1 jR_tabla1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jR_tabla1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jR_tabla1);
        }

        // GET: JR_tabla1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jR_tabla1 = await _context.JR_tabla1.FindAsync(id);
            if (jR_tabla1 == null)
            {
                return NotFound();
            }
            return View(jR_tabla1);
        }

        // POST: JR_tabla1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JR_Int_Atributo1,JR_String_Atributo2,JR_Booleano_Atributo3,JR_Decimal_Atributo4,JR_Fecha_Atributo5")] JR_tabla1 jR_tabla1)
        {
            if (id != jR_tabla1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jR_tabla1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JR_tabla1Exists(jR_tabla1.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(jR_tabla1);
        }

        // GET: JR_tabla1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jR_tabla1 = await _context.JR_tabla1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jR_tabla1 == null)
            {
                return NotFound();
            }

            return View(jR_tabla1);
        }

        // POST: JR_tabla1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jR_tabla1 = await _context.JR_tabla1.FindAsync(id);
            if (jR_tabla1 != null)
            {
                _context.JR_tabla1.Remove(jR_tabla1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JR_tabla1Exists(int id)
        {
            return _context.JR_tabla1.Any(e => e.Id == id);
        }
    }
}
