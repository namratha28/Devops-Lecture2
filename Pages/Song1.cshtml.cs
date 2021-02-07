using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace lab2.Pages
{
    public class Song1Model : PageModel
    {
        private readonly ILogger<Song1Model> _logger;

        public Song1Model(ILogger<Song1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
