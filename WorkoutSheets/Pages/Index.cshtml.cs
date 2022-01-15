namespace WorkoutSheets.Pages;

public class IndexModel : PageModel
{
	private readonly IWebHostEnvironment _hostingEnvironment;

	public List<string> Files { get; } = new();

	public IndexModel(IWebHostEnvironment hostingEnvironment)
	{
		_hostingEnvironment = hostingEnvironment;
	}

	public void OnGet()
	{
		Files.AddRange(GetFiles("Beginner"));
		Files.AddRange(GetFiles("Intermediate"));
	}

	private IEnumerable<string> GetFiles(string folder)
	{
		var path = Path.Combine(_hostingEnvironment.ContentRootPath, "Pages", folder);

		return Directory
			.EnumerateFiles(path, "*.cshtml")
			.Select(i => $"{folder}/{Path.GetFileNameWithoutExtension(i)}");
	}
}
