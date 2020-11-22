
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Madera.Models;
using Madera.Models.Search;
using System.Security.Permissions;
using System;

namespace Madera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProjetsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Projets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projet>>> GetProjets()
        {
            return await _context.Projets.ToListAsync();
        }

        // GET: api/Projets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Projet>> GetProjet(int id)
        {
            var projet = await _context.Projets.FindAsync(id);

            if (projet == null)
            {
                return NotFound();
            }

            return projet;
        }

        // GET: api/Projets/5
        [HttpPost("search")]
        public async Task<List<Projet>> GetListeProjet([FromBody] ProjetCommercial search)
        {
            var listeProject =  _context.Projets.Select(p => p);

            if (!string.IsNullOrWhiteSpace(search.LibelleProjet))
                listeProject = listeProject.Where(p => p.LibelleProjet.ToLower().Contains(search.LibelleProjet.ToLower()));

            if (search.ClientID != 0)
                listeProject = listeProject.Where(p => p.ClientID == search.ClientID);

            if (search.DateCreation.Date != null)
                listeProject = listeProject.Where(p => p.DateCreation.Date == search.DateCreation.Date);

            return await listeProject.ToListAsync();
        }

        [HttpPost("remarque")]
        public async Task<IActionResult> EditRemarque([FromBody] EditRemarque editRemarque) {
            var projet = await _context.Projets.Where(p => p.ID == editRemarque.id).FirstOrDefaultAsync();
            if (projet == null) return NotFound($"L'identifiant {editRemarque.id} ne correspond à aucun projet.");


            projet.LibelleRemarque = editRemarque.remarque;
            await _context.SaveChangesAsync();

            return Ok();
        }


        // PUT: api/Projets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchProjet(int id, Projet projet)
        {
            if (id != projet.ID)
            {
                return BadRequest();
            }

            _context.Entry(projet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Projets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Projet>> PostProjet(Projet projet)
        {
            _context.Projets.Add(projet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjet", new { id = projet.ID }, projet);
        }

        // DELETE: api/Projets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Projet>> DeleteProjet(int id)
        {
            var projet = await _context.Projets.FindAsync(id);
            if (projet == null)
            {
                return NotFound();
            }

            _context.Projets.Remove(projet);
            await _context.SaveChangesAsync();

            return projet;
        }

        private bool ProjetExists(int id)
        {
            return _context.Projets.Any(e => e.ID == id);
        }
    }
}
