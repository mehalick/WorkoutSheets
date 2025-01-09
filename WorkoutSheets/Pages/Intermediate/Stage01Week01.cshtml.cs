namespace WorkoutSheets.Pages.Intermediate;

public class Stage01Week01Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Intermediate,
		Stage = 1,
		WeekRange = new(1, 3),
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4, 4, 4, 4, 4, 4, 4],
				SuperSets =
				[
					["Thin Tummy", "Curlup, Arms Parallel", "Russian Twist", "Pushup Hold"],
					["Standing Single-leg Calf", "Calf Raise Leg Press", "Seated Single-leg Calf"],
					["DB Wrist Curl", "DB Wrist Ext"],
					["DB Lying Pullover", "DB Seated Lat Raise"],
					["DB Seated Shoulder Press", "Lat Pulldown (Behind Neck)"],
					["BB Seated Shoulder Press", "Lat Pulldown"]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					["Toes to Sky", "Curlup, Legs in Air", "Side Raise", "Seated Thin Tummy"],
					["EZ Curl (Wide Grip)", "EZ Curl (Reverse Grip)", "EZ Curl (Close Grip)"],
					["Triceps Pushdown (Reverse)", "Triceps Pushdown (Wide)", "Triceps Pushdown (Neutral)"],
					["Leg Curl", "Leg Extension"],
					["Single-leg Deadlift", "Single-leg Squat"],
					["Kind Deadlift", "Single-leg Squat"],
					["Deadlift", "Barbell Squat"]
				]
			},
			new Workout
			{
				Letter = "C",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					["Thin Tummy", "Curlup, Arms Parallel", "Russian Twist", "Pushup Hold"],
					["DB Shrug (Behind Body)", "DB Shrug", "DB Shrug (To Front)"],
					["BB Wrist Ext", "BB Wrist Curl"],
					["Reverse DB Fly", "DB Fly"],
					["DB One-arm Row", "DB Incline Press"],
					["Seated Cable Row", "Bench Press"]
				]
			}
		]
	};
}
