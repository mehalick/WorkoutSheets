using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages.Intermediate
{
	public class Stage01Week01Model : PageModel
	{
		public Week Week = new Week
		{
			Program = Models.Program.Intermediate,
			Stage = 1,
			WeekRange = new WeekRange(1, 3),
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{4, 4, 4},
					SuperSets = new []
					{
						new []{ "Thin Tummy", "Curlup, Arms Parallel", "Russian Twist", "Pushup Hold" },
						new []{ "Standing Single-leg Calf", "Calf Raise Leg Press", "Seated Single-leg Calf" },
						new []{ "DB Wrist Curl", "DB Wrist Ext" },
						new []{ "DB Lying Pullover", "DB Seated Lat Raise" },
						new []{ "DB Seated Shoulder Press", "Lat Pulldown (Behind Neck)" },
						new []{ "BB Seated Shoulder Press", "Lat Pulldown" },
					}
				},
				new Workout
				{
					Letter = "B",
					ColumnsPerDay = new []{4, 4, 4},
					SuperSets = new []
					{
						new []{ "Toes to Sky", "Curlup, Legs in Air", "Side Raise", "Seated Thin Tummy" },
						new []{ "EZ Curl (Wide Grip)", "EZ Curl (Reverse Grip)", "EZ Curl (Close Grip)" },
						new []{ "Triceps Pushdown (Reverse)", "Triceps Pushdown (Wide)", "Triceps Pushdown (Neutral)" },
						new []{ "Leg Curl", "Leg Extension" },
						new []{ "Single-leg Deadlift", "Single-leg Squat" },
						new []{ "Kind Deadlift", "Single-leg Squat" },
						new []{ "Deadlift", "Barbell Squat" },
					}
				},
				new Workout
				{
					Letter = "C",
					ColumnsPerDay = new []{4, 4, 4},
					SuperSets = new []
					{
						new []{ "Thin Tummy", "Curlup, Arms Parallel", "Russian Twist", "Pushup Hold" },
						new []{ "DB Shrug (Behind Body)", "DB Shrug", "DB Shrug (To Front)" },
						new []{ "BB Wrist Ext", "BB Wrist Curl" },
						new []{ "Reverse DB Fly", "DB Fly" },
						new []{ "DB One-arm Row", "DB Incline Press" },
						new []{ "Seated Cable Row", "Bench Press" },
					}
				}
			}
		};
	}
}
