using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroDeConteiners.Data;
using RegistroDeConteiners.Models;

namespace RegistroDeConteiners.Pages_Report
{
    public class IndexModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public IndexModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }
        
        public IList<Movimentacoes> MovimentacoesAgrupadas { get;set; }
        public int totalImportacao = 0;
        public int totalExportacao = 0;

        public async Task OnGetAsync()
        {

            MovimentacoesAgrupadas = await _context.Movimentacoes
            .GroupBy(m => new {
                Cliente = m.Conteiner.Cliente,
                TipodeMv = m.TipodeMv
            })
            .Select(g => new Movimentacoes {
                Conteiner = new Conteiner{ Cliente = g.Key.Cliente },
                TipodeMv = g.Key.TipodeMv
            })
            .ToListAsync();

            totalImportacao = await _context.Movimentacoes
                .Where(m => m.Conteiner.Categoria == "Importação")
                .CountAsync();

            totalExportacao = await _context.Movimentacoes
                .Where(m => m.Conteiner.Categoria == "Exportação")
                .CountAsync();

            
        }
    }
}
