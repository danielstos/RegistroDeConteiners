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
    public class IndexModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public IndexModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }

        public IList<Movimentacoes> Movimentacoes { get;set; }

        public async Task OnGetAsync()
        {
            Movimentacoes = await _context.Movimentacoes
                .Include(m => m.Conteiner).ToListAsync();
        }
    }
}
