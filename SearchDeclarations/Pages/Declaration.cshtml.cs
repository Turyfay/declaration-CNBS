using Declaration.Core.Entities;
using Declaration.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace SearchDeclarations.Pages
{
    public class DeclarationModel : PageModel
    {
        private readonly ILogger<DeclarationModel> _logger;
        private readonly ISearchDeclarationService _searchService;

        public DeclarationModel(ILogger<DeclarationModel> logger, ISearchDeclarationService searchDeclarationService)
        {
            _logger = logger;
            _searchService = searchDeclarationService;
        }

        [BindProperty]
        public string SearchParameter { get; set; }
        public List<DDT> SearchResults { get; set; } = new List<DDT>();

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            if (!string.IsNullOrEmpty(SearchParameter))
            {
                SearchResults = await _searchService.SearchDeclarationAsync(SearchParameter);
            }
        }
    }

}
