namespace WorkoutSheets.Pages.Intermediate;

public class Stage02Week08Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Intermediate,
		Stage = 2,
		WeekRange = new(8, 10),
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Knee-Up (Incline)", "Curlup (Weighted)", "Side Raise", "Swiss-Ball"],
					["Barbell Shoulder Press", "DB Shoulder Press", "DB Lat Raise", "Deadlift", "Stiff-Legged Deadlift", "Good Morning", "Seated Calf Raise", "Standing Calf Raise", "Single-Leg Calf Raise"]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Toes to Sky", "Barbell Rollout", "Russian Twist", "Modified V-sit"],
					["Bent Over Row", "Seated Cable Row", "DB One-Arm Row", "Bench Press (Incline Wide)", "Bench Press (Wide Neck)", "DB Bench Press (Decline)"],
					["DB Hammer Curl (Incline)", "Dip"]
				]
			},
			new Workout
			{
				Letter = "C",
				ColumnsPerDay = [6, 6, 6],
				SuperSets =
				[
					["Knee-Up (Incline)", "Curlup (Legs in Air)", "Russian Twist", "Swiss-Ball"],
					["Chinup", "Lat Pulldown", "DB Lying Pullover", "Barbell Squat", "Static Lunge", "Leg Press (Single Leg)", "Barbell Shrug (Reverse)", "Barbell Shrug", "Barbell Shrug (Wide)"]
				]
			}
		]
	};
}
