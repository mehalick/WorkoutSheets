namespace WorkoutSheets.Pages.Beginner;

public class Stage01Week04Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Beginner,
		Stage = 1,
		WeekRange = new(4, 6),
		PrintSize = PrintSize.Landscape,
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4, 4, 4, 4, 4, 4, 4],
				SuperSets =
				[
					[
						"Thin Tummy (one leg lift)",
						"Static Lunge",
						"Leg Press",
						"Dumbbell Lying Row",
						"Dumbbell Upright Row"
					],
					[
						"Curlup (arms parallel)",
						"Dumbbell Bench Step",
						"Leg Curl",
						"Dumbbell Lying Pullover",
						"Dumbbell Bench Press"
					],
					[
						"Pushup Hold",
						"Leg Extension",
						"Single-leg Calf Raise",
						"Dumbbell Seated Curl",
						"Dumbbell Triceps"
					]
				]
			}
		]
	};
}
