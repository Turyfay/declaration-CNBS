using Declaration.Core.Data;
using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Services
{
    public class SearchDeclarationService: ISearchDeclarationService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        public SearchDeclarationService(IDbContextFactory<ApplicationDbContext> contextFactory) {
            _contextFactory = contextFactory;
        }

        public async Task<List<DDT>> SearchDeclarationAsync(string Nddtimmioe) 
        {
            List<DDT> dDTs = new List<DDT>();
            using var context = _contextFactory.CreateDbContext();
            dDTs =  await context.DDTs.Where(d => d.Nddtimmioe.Contains(Nddtimmioe)).ToListAsync();
            return dDTs;
        }
        public async Task<LIQ> SearchLIQAsync(string Iliq)
        {
            LIQ? liq;
            using var context = _contextFactory.CreateDbContext();
            liq = await context.LIQs.SingleOrDefaultAsync(l => l.Iliq == Iliq);
            return liq;
        }
    }
}
