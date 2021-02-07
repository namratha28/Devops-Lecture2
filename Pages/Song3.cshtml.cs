using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace lab2.Pages
{
    public class Song3Model : PageModel
    {
        private readonly ILogger<Song3Model> _logger;

        public Song3Model(ILogger<Song3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
