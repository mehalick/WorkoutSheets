using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WorkoutSheets.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public IEnumerable<string> Files { get; private set; }

        public IndexModel(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnGet()
        {
            var path = Path.Combine(_hostingEnvironment.ContentRootPath, @"Pages");

            Files = Directory.EnumerateFiles(path, "stage-*.cshtml").Select(Path.GetFileNameWithoutExtension);
        }
    }
}
