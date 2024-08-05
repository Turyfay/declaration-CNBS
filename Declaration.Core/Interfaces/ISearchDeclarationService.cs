using Declaration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Interfaces
{
    public interface ISearchDeclarationService
    {
        Task<List<DDT>> SearchDeclarationAsync(string Nddtimmioe);
        Task<LIQ> SearchLIQAsync(string Iliq);
    }
}
