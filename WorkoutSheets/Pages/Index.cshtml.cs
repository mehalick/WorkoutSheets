using Humanizer;

namespace WorkoutSheets.Pages;

public class IndexModel : PageModel
{
	private readonly IWebHostEnvironment _hostingEnvironment;

	public List<File> Files { get; } = [];

	public IndexModel(IWebHostEnvironment hostingEnvironment)
	{
		_hostingEnvironment = hostingEnvironment;
	}

	public void OnGet()
	{
		Files.AddRange(GetFiles("Beginner"));
		Files.AddRange(GetFiles("Intermediate"));
	}

	private IEnumerable<File> GetFiles(string folder)
	{
		var path = Path.Combine(_hostingEnvironment.ContentRootPath, "Pages", folder);

		return Directory
			.EnumerateFiles(path, "*.cshtml")
			.Select(Path.GetFileNameWithoutExtension)
			.Select(i => new File($"{folder} - {i.Humanize(LetterCasing.Title)}", $"{folder}/{i}"));
	}
}

public record File(string Name, string Path);
