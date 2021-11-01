using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _contex;
        public LancheRepository(AppDbContext contexto)
        {
            _contex = contexto;
        }

        public IEnumerable<Lanche> Lanches => _contex.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contex.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _contex.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
