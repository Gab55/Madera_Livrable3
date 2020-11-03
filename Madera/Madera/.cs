using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Madera.Models;

namespace Madera
{
    public class ProjetController : Controller
    {
        private readonly AppDbContext _context;

        public ProjetController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Projet
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projets.ToListAsync());
        }

        // GET: Projet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projet = await _context.Projets
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projet == null)
            {
                return NotFound();
            }

            return View(projet);
        }

        // GET: Projet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CommercialID,ClientID,LibelleProjet,LibelleNom,LibelleRemarque,DateDebutProjet,IdUtilisateurCreation,DateCreation,IdUtilisateurModification,DateModification,DateArchivage")] Projet projet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projet);
        }

        // GET: Projet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projet = await _context.Projets.FindAsync(id);
            if (projet == null)
            {
                return NotFound();
            }
            return View(projet);
        }

        // POST: Projet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CommercialID,ClientID,LibelleProjet,LibelleNom,LibelleRemarque,DateDebutProjet,IdUtilisateurCreation,DateCreation,IdUtilisateurModification,DateModification,DateArchivage")] Projet projet)
        {
            if (id != projet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetExists(projet.ID))
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
            return View(projet);
        }

        // GET: Projet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projet = await _context.Projets
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projet == null)
            {
                return NotFound();
            }

            return View(projet);
        }

        // POST: Projet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projet = await _context.Projets.FindAsync(id);
            _context.Projets.Remove(projet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetExists(int id)
        {
            return _context.Projets.Any(e => e.ID == id);
        }
    }
}
