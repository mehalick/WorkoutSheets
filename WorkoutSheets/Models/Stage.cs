namespace WorkoutSheets.Models;

public record Stage
{
	public string Title { get; init; } = "";
	public IEnumerable<string> Exercises { get; init; } = Array.Empty<string>();
	public IEnumerable<int> SetsPerDay { get; init; } = Array.Empty<int>();
	public IEnumerable<int> Supersets { get; init; } = Array.Empty<int>();
	public bool HighlightColumns { get; init; } = true;
}

public record Week
{
	public Program Program { get; init; }
	public int Stage { get; init; }
	public WeekRange WeekRange { get; init; }
	public PrintSize PrintSize { get; init; } = PrintSize.Landscape;
	public IEnumerable<Workout> Workouts { get; init; } = Array.Empty<Workout>();
}

public record Workout
{
	public string Letter { get; init; } = "";
	public IEnumerable<int> ColumnsPerDay { get; init; } = Array.Empty<int>();
	public IEnumerable<IEnumerable<string>> SuperSets { get; init; } = new List<IEnumerable<string>>();
}

public enum Program
{
	Beginner, Intermediate, Advanced
}

public enum PrintSize
{
	Landscape, Portrait
}

public readonly struct WeekRange
{
	public int Start { get; }
	public int End { get; }

	public WeekRange(int start, int end)
	{
		Start = start;
		End = end;
	}
}
