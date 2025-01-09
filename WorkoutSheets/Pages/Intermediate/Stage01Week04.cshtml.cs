namespace WorkoutSheets.Pages.Intermediate;

public class Stage01Week04Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Intermediate,
		Stage = 1,
		WeekRange = new(4, 6),
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Thin Tummy", "Curlup (Arms Parallel)", "Russian Twist", "Modified V-Sit"],
					["DB Seated Curl (Twist)", "EZ Curl (Reverse Grip)"],
					["Reverse DB Fly", "Seated Cable Row (Reverse)"],
					["Seated Cable Row"],
					["DB Lying Pullover", "Lat Pulldown (Wide Grip)"],
					["Lat Pulldown (Neutral Grip)"]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Toes to Sky", "Curlup (Legs in Air)", "Side Raise", "Wrist-to-Knee Curlup"],
					["Leg Curl", "Leg Extension"],
					["Barbell Squat (Breathing)"],
					["Prone Hip-High Ext", "Back Extension", "Good Morning"],
					["Deadlift"],
					["Standing Calf Raise"]
				]
			},
			new Workout
			{
				Letter = "C",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Thin Tummy", "Curlup (Hands on Elbows)", "Russian Twist", "Modified V-Sit"],
					["DB Overhead Triceps Ext", "Barbell Bench Press (Very Close)"],
					["DB Seated Lat Raise", "Barbell Upright Row"],
					["Barbell Seated Shoulder Press"],
					["DB Fly (Thumbs In)", "Barbell Bench Press (Incline Wide)"],
					["Barbell Bench Press"]
				]
			}
		]
	};
}
