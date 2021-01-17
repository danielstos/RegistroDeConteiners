using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroDeConteiners.Data;
using RegistroDeConteiners.Models;

namespace RegistroDeConteiners.Pages_Conteiners
{
    public class EditModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public EditModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Conteiner Conteiner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conteiner = await _context.Conteiner.FirstOrDefaultAsync(m => m.ID == id);

            if (Conteiner == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Conteiner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConteinerExists(Conteiner.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ConteinerExists(int id)
        {
            return _context.Conteiner.Any(e => e.ID == id);
        }
    }
}
