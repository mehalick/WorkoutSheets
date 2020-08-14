using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages
{
	public class Stage02Week08Model : PageModel
	{
		public Week Week = new Week
		{
			Program = Models.Program.Intermediate,
			Stage = 2,
			WeekRange = new WeekRange(8, 10),
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Knee-Up (Incline)", "Curlup (Weighted)", "Side Raise", "Swiss-Ball" },
						new []{ "Barbell Shoulder Press", "DB Shoulder Press", "DB Lat Raise", "Deadlift", "Stiff-Legged Deadlift", "Good Morning", "Seated Calf Raise", "Standing Calf Raise", "Single-Leg Calf Raise" }
					}
				},
				new Workout
				{
					Letter = "B",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Toes to Sky", "Barbell Rollout", "Russian Twist", "Modified V-sit" },
						new []{ "Bent Over Row", "Seated Cable Row", "DB One-Arm Row", "Bench Press (Incline Wide)", "Bench Press (Wide Neck)", "DB Bench Press (Decline)" },
						new []{ "DB Hammer Curl (Incline)", "Dip" }
					}
				},
				new Workout
				{
					Letter = "C",
					ColumnsPerDay = new []{6, 6, 6},
					SuperSets = new []
					{
						new []{ "Knee-Up (Incline)", "Curlup (Legs in Air)", "Russian Twist", "Swiss-Ball" },
						new []{ "Chinup", "Lat Pulldown", "DB Lying Pullover", "Barbell Squat", "Static Lunge", "Leg Press (Single Leg)", "Barbell Shrug (Reverse)", "Barbell Shrug", "Barbell Shrug (Wide)" }
					}
				}
			}
		};
	}
}
