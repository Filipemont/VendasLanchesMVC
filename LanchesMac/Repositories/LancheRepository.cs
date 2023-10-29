using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
            Where(p => p.isLanchePreferido).
            Include(c => c.categoria);

        public Lanche GetLancheById(int lancheid) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheid);
    }
}
