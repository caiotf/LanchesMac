using LanchesMac.Context;
using LanchesMac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contex;
        public CategoriaRepository(AppDbContext contexto)
        {
            _contex = contexto;
        }

        public IEnumerable<Categoria> Cagetorias => _contex.Categorias;
    }
}
