using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages
{
    public class Stage03Week15Model : PageModel
    {
        public Week Week = new Week
		{
			Program = Models.Program.Intermediate,
			Stage = 3,
			WeekRange = new WeekRange(15, 17),
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{ 4, 4, 4 },
					SuperSets = new []
					{
						new []{ "Wide-grip Pullup 1/2", "Wide-grip Pullup 2/2", "Lat Pulldown (Reverse)", "Lat Pulldown (Neutral)", "Barbell Row", "Barbell Row (Reverse)", "Barbell Row (Wide)", "EZ Bar Curl" },
						new []{ "Thin Tummy", "Curlup (Arms Straight)", "Russian Twist", "Pushup Hold" }
					}
				},
				new Workout
				{
					Letter = "B",
					ColumnsPerDay = new []{ 4, 4, 4 },
					SuperSets = new []
					{
						new []{ "Deadlift 1/2", "Deadlift 2/2", "Deadlift (Wide)", "Deadlift (Blocks)", "Barbell Squat (Front)", "Barbell Squat (High)", "Barbell Squat (Narrow)", "Barbell Shrug" },
						new []{ "Toes to Sky", "Curlup (Legs Up)", "Side Raise", "Thin Tummy (Seated)" }
					}
				},
				new Workout
				{
					Letter = "C",
					ColumnsPerDay = new []{ 4, 4, 4 },
					SuperSets = new []
					{
						new []{ "Bench Press 1/2", "Bench Press 2/2", "Bench Press (Wide)", "Bench Press (Feet on Bench)", "Shoulder Press", "Shoulder Press (Front)", "Shoulder Press (Wide)", "Triceps Extension" },
						new []{ "Thin Tummy", "Curlup (Arms Straight)", "Russian Twist", "Pushup Hold" }
					}
				}
			}
		};
    }
}
