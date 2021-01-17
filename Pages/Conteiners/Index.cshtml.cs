using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroDeConteiners.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RegistroDeConteiners.Pages_Conteiners
{
    public class IndexModel : PageModel
    {
        private readonly RegistroDeConteiners.Data.RegistroDeConteinersContext _context;

        public IndexModel(RegistroDeConteiners.Data.RegistroDeConteinersContext context)
        {
            _context = context;
        }

        public IList<Conteiner> Conteiner { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Clientes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ConteinerCliente { get; set; }




        public async Task OnGetAsync()

        {

            // Use LINQ to get list of Clientes.
            IQueryable<string> clienteQuery = from m in _context.Conteiner
                                              orderby m.Cliente
                                              select m.Cliente;

            var Conteiners = from m in _context.Conteiner
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Conteiners = Conteiners.Where(s => s.Numerodecntr.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ConteinerCliente))
            {
                Conteiners = Conteiners.Where(x => x.Cliente == ConteinerCliente);
            }
            Clientes = new SelectList(await clienteQuery.Distinct().ToListAsync());

            Conteiner = await Conteiners.ToListAsync();
        }
    }
}
