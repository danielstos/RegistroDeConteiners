using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroDeConteiners.Data;
using RegistroDeConteiners.Models;

namespace RegistroDeConteiners.Pages_Movimentacoes
{
    public class DetailsModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public DetailsModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }

        public Movimentacoes Movimentacoes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movimentacoes = await _context.Movimentacoes
                .Include(m => m.Conteiner).FirstOrDefaultAsync(m => m.ID == id);

            if (Movimentacoes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
