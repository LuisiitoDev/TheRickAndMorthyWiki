using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRickAndMorthy.Models;
using TheRickAndMorthy.Services;

namespace TheRickAndMorthyWiki.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RickAndMorthyService rickAndMorthyService;

        IEnumerable<Character> characters;
        public IndexModel(ILogger<IndexModel> logger, RickAndMorthyService rickAndMorthyService)
        {
            _logger = logger;
            this.rickAndMorthyService = rickAndMorthyService;
        }

        public async Task OnGet()
        {
            var response = await this.rickAndMorthyService.GetCharactersAsync();
            this.characters = response.results;
        }
    }
}
