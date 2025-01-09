namespace WorkoutSheets.Pages.Intermediate;

public class Stage02Week11Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Intermediate,
		Stage = 2,
		WeekRange = new(11, 13),
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Modified V-sit", "Knee-Up", "Curlup", "Russian Twist", "Side Raise"],
					["Shoulder Press", "Shoulder Press", "Barbell Squat", "Barbell Squat"],
					["Barbell Shrug"]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Knee-Up", "Curlup", "Lat Leg Lowering", "Side Raise", "Pushup Hold"],
					["Bent Over Row", "Bent Over Row","Bench Press","Bench Press"],
					["DB Hammer Curl"]
				]
			},
			new Workout
			{
				Letter = "C",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Knee-Up", "Barbell Rollout", "Side Raise", "Russian Twist", "Curlup"],
					["Chinup", "Chinup", "Deadlift", "Deadlift"],
					["Calf Raise"]
				]
			}
		]
	};
}
