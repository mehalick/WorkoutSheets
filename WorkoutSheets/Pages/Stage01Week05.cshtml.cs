using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutSheets.Models;

namespace WorkoutSheets.Pages
{
	public class Stage01Week05Model : PageModel
	{
		public Week Week = new Week
		{
			Workouts = new[]
			{
				new Workout
				{
					Letter = "A",
					ColumnsPerDay = new []{4, 4, 4},
					SuperSets = new []
					{
						new []{ "Thin Tummy", "Curlup", "Russian Twist", "Pushup Hold" },
						new []{ "Standing Single-leg Calf", "Calf Raise Leg Press", "Seated Single-leg Calf" },
						new []{ "DB Wrist Curl", "DB Wrist Ext" },
						new []{ "DB Lying Pullover", "DB Seated Lat Raise" },
						new []{ "DB Seated Shoulder Press", "Lat Pulldown Behind Neck" },
						new []{ "BB Seated Shoulder Press", "Lat Pulldown" },
					}
				}
			}
		};
	}
}
