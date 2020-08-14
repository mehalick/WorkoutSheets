using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages
{
	public class Stage02Week11Model : PageModel
	{
		public Week Week = new Week
		{
			Program = Models.Program.Intermediate,
			Stage = 2,
			WeekRange = new WeekRange(11, 13),
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{ 6, 6, 6 },
					SuperSets = new []
					{
						new []{ "Modified V-sit", "Knee-Up", "Curlup", "Russian Twist", "Side Raise" },
						new []{ "Shoulder Press", "Shoulder Press", "Barbell Squat", "Barbell Squat" },
						new []{ "Barbell Shrug" }
					}
				},
				new Workout
				{
					Letter = "B",
					ColumnsPerDay = new []{ 6, 6, 6 },
					SuperSets = new []
					{
						new []{ "Knee-Up", "Curlup", "Lat Leg Lowering", "Side Raise", "Pushup Hold" },
						new []{ "Bent Over Row", "Bent Over Row","Bench Press","Bench Press" },
						new []{ "DB Hammer Curl" }
					}
				},
				new Workout
				{
					Letter = "C",
					ColumnsPerDay = new []{ 6, 6, 6 },
					SuperSets = new []
					{
						new []{ "Knee-Up", "Barbell Rollout", "Side Raise", "Russian Twist", "Curlup" },
						new []{ "Chinup", "Chinup", "Deadlift", "Deadlift" },
						new []{ "Calf Raise" }
					}
				}
			}
		};
	}
}
