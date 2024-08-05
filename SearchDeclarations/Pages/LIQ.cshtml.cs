using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetTopologySuite.Mathematics;
using Newtonsoft.Json;

namespace SearchDeclarations.Pages
{
    public class LIQModel : PageModel
    {
        private readonly ISearchDeclarationService _searchService;

        public LIQModel(ISearchDeclarationService searchService)
        {
            _searchService = searchService;
        }
        public LIQ DataLIQ { get; set; }
        public async Task OnGet(string liq)
        {
            if (!string.IsNullOrEmpty(liq))
            {
                DataLIQ = await _searchService.SearchLIQAsync(liq);
            }
        }
    }
}
