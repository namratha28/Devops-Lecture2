using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace lab2.Pages
{
    public class Song2Model : PageModel
    {
        private readonly ILogger<Song2Model> _logger;

        public Song2Model(ILogger<Song2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
