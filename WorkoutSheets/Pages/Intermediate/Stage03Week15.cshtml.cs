namespace WorkoutSheets.Pages.Intermediate;

public class Stage03Week15Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Intermediate,
		Stage = 3,
		WeekRange = new(15, 17),
		Workouts =
		[
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					["Wide-grip Pullup 1/2", "Wide-grip Pullup 2/2", "Lat Pulldown (Reverse)", "Lat Pulldown (Neutral)", "Barbell Row", "Barbell Row (Reverse)", "Barbell Row (Wide)", "EZ Bar Curl"],
					["Thin Tummy", "Curlup (Arms Straight)", "Russian Twist", "Pushup Hold"]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					["Deadlift 1/2", "Deadlift 2/2", "Deadlift (Wide)", "Deadlift (Blocks)", "Barbell Squat (Front)", "Barbell Squat (High)", "Barbell Squat (Narrow)", "Barbell Shrug"],
					["Toes to Sky", "Curlup (Legs Up)", "Side Raise", "Thin Tummy (Seated)"]
				]
			},
			new Workout
			{
				Letter = "C",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					["Bench Press 1/2", "Bench Press 2/2", "Bench Press (Wide)", "Bench Press (Feet on Bench)", "Shoulder Press", "Shoulder Press (Front)", "Shoulder Press (Wide)", "Triceps Extension"],
					["Thin Tummy", "Curlup (Arms Straight)", "Russian Twist", "Pushup Hold"]
				]
			}
		]
	};
}
