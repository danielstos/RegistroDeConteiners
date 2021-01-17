using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistroDeConteiners.Data;
using RegistroDeConteiners.Models;

namespace RegistroDeConteiners.Pages_Movimentacoes
{
    public class CreateModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public CreateModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ConteinerID"] = new SelectList(_context.Conteiner, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Movimentacoes Movimentacoes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movimentacoes.Add(Movimentacoes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
