using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SerilogExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("in index page");

            try
            {
                for (int i = 0; i < 50; i++)
                {
                    if (i==30)
                    {
                        throw new Exception("this is exeption");
                    }
                    else
                    {
                        _logger.LogInformation("number is {Value}",i);
                    }
                }
            }
            catch (Exception e)
            {
               _logger.LogError(e,"Error...");
            }
        }
    }
}