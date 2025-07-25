namespace WorkoutSheets.Pages.Beginner;

public class Stage01Week01Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Beginner,
		Stage = 1,
		WeekRange = new(1, 3),
		PrintSize = PrintSize.Landscape,
		Workouts =
		[
			new()
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4, 4, 4, 4, 4, 4, 4],
				SuperSets =
				[
					[
						"Thin Tummy",
						"Static Lunge",
						"Dumbbell Lying Row",
						"Dumbbell Upright Row",
						"Curlup (cheat)",
						"Dumbbell Bench Step",
						"Dumbbell Lying Pullover",
						"Dumbbell Bench Press",
						"Push-up Hold",
						"Single-leg Calf Raise",
						"Dumbbell Seated Curl",
						"Dumbbell Triceps"
					]
				]
			}
		]
	};
}
