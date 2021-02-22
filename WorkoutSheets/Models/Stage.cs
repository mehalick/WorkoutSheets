using System.Collections.Generic;

namespace WorkoutSheets.Models
{
	public class Stage
	{
		public string Title { get; set; }
		public IEnumerable<string> Exercises { get; set; }
		public IEnumerable<int> SetsPerDay { get; set; }
		public IEnumerable<int> Supersets { get; set; } = new List<int>();
		public bool HighlightColumns { get; set; } = true;
	}

	public class Week
	{
		public Program Program { get; set; }
		public int Stage { get; set; }
		public WeekRange WeekRange { get; set; }
		public PrintSize PrintSize { get; set; } = PrintSize.Landscape;
		public IEnumerable<Workout> Workouts { get; set; }
	}

	public class Workout
	{
		public string Letter { get; set; }
		public IEnumerable<int> ColumnsPerDay { get; set; }
		public IEnumerable<IEnumerable<string>> SuperSets { get; set; }
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
}
