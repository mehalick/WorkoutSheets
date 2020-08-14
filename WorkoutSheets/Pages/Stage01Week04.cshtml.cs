using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages
{
	public class Stage01Week04Model : PageModel
	{
		public Week Week = new Week
		{
			Program = Models.Program.Intermediate,
			Stage = 1,
			WeekRange = new WeekRange(4, 6),
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Thin Tummy", "Curlup (Arms Parallel)", "Russian Twist", "Modified V-Sit" },
						new []{ "DB Seated Curl (Twist)", "EZ Curl (Reverse Grip)" },
						new []{ "Reverse DB Fly", "Seated Cable Row (Reverse)" },
						new []{ "Seated Cable Row" },
						new []{ "DB Lying Pullover", "Lat Pulldown (Wide Grip)" },
						new []{ "Lat Pulldown (Neutral Grip)" },
					}
				},
				new Workout
				{
					Letter = "B",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Toes to Sky", "Curlup (Legs in Air)", "Side Raise", "Wrist-to-Knee Curlup" },
						new []{ "Leg Curl", "Leg Extension" },
						new []{ "Barbell Squat (Breathing)" },
						new []{ "Prone Hip-High Ext", "Back Extension", "Good Morning" },
						new []{ "Deadlift" },
						new []{ "Standing Calf Raise" },
					}
				},
				new Workout
				{
					Letter = "C",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Thin Tummy", "Curlup (Hands on Elbows)", "Russian Twist", "Modified V-Sit" },
						new []{ "DB Overhead Triceps Ext", "Barbell Bench Press (Very Close)" },
						new []{ "DB Seated Lat Raise", "Barbell Upright Row" },
						new []{ "Barbell Seated Shoulder Press" },
						new []{ "DB Fly (Thumbs In)", "Barbell Bench Press (Incline Wide)" },
						new []{ "Barbell Bench Press" },
					}
				}
			}
		};
	}
}
