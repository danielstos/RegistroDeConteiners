using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RegistroDeConteiners.Data;
using System;
using System.Linq;

namespace RegistroDeConteiners.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RegistroDeConteinersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RegistroDeConteinersContext>>()))
            {
                // Look for any Conteiners.
                if (context.Conteiner.Any())
                {
                    return;   // DB has been seeded
                }


                context.Conteiner.AddRange(
                    new Conteiner
                    {
                        Cliente = "Master",
                        Numerodecntr = "HSCU7213331",
                        Tipo = 40,
                        Status = "Vazio",
                        Categoria = "Importação"

                    },

                    new Conteiner
                    {
                        Cliente = "Mcc",
                        Numerodecntr = "BACU7113881",
                        Tipo = 20,
                        Status = "Cheio",
                        Categoria = "Exportação"

                    },
                  new Conteiner
                  {
                      Cliente = "Hepeer",
                      Numerodecntr = "CAIU2353331",
                        Tipo = 40,
                      Status = "Vazio",
                      Categoria = "Exportação"

                  },

                  new Conteiner
                  {
                      Cliente = "Aplter",
                      Numerodecntr = "CHLU4235731",
                        Tipo = 20,
                      Status = "Cheio",
                      Categoria = "Importação"


                  },

                  new Conteiner
                  {
                      Cliente = "Master",
                      Numerodecntr = "CHLU4235731",
                      Tipo = 20,
                      Status = "Cheio",
                      Categoria = "Importação"

                  }

                );
                context.SaveChanges();
            }
        }
    }
}