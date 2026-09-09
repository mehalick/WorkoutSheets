namespace WorkoutSheets.Pages.Beginner;

public class Stage01Week08Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Beginner,
		Stage = 1,
		WeekRange = new(8, 10),
		PrintSize = PrintSize.Landscape,
		Workouts =
		[
			new()
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4, 4],
				SuperSets =
				[
					[
						"Thin Tummy, Lift One Leg (10)",
						"Curlup, Arms Straight & Parallel (10-20)",
						"Side Raise (10-15)",
						"Seated Thin Tummy + Cheek Squeeze (10)"
					],
					[
						"King Deadlift (MAX)",
						"Single Leg Squat, Other Leg Out Front (MAX)"
					],
					[
						"Prone Hip-Thigh Extension (12-15)",
						"Static Lunge, Back Foot on Low Block (12-15)"
					],
					[
						"Single-Leg Stiff-Legged Deadlift (MAX)",
						"Single-Leg Squat, on Low Block (MAX)"
					],
					[
						"Leg Curl (12-15)",
						"Leg Extension (12-15)"
					],
					[
						"Seated Calf Raise (15-20)",
						"Standing Single-Leg Calf Raise (15-20)"
					],
					[
						"Dumbbell Shrug, Behind Body (12-15)",
						"Dumbbell Shrug, To Front (12-15)"
					]
				]
			},
			new()
			{
				Letter = "B",
				ColumnsPerDay = [4, 4, 4, 4],
				SuperSets =
				[
					[
						"Toes to Sky (10)",
						"Curlup, Legs in Air Arms Crossed (10-15)",
						"Lateral Leg Lowering (10-15)",
						"Pushup Hold, Lift Leg Then Arm (10)"
					],
					[
						"Seated Cable Row (12-15)",
						"Barbell Bench Press, Feet on Bench (12-15)"
					],
					[
						"Reverse Dumbbell Fly (12-15)",
						"Dumbbell Fly (12-15)"
					],
					[
						"Lat Pulldown (12-15)",
						"Barbell Seated Shoulder Press, To Front (12-15)"
					],
					[
						"Dumbbell Lying Pullover, 1 Dumbbell (12-15)",
						"Dumbbell Seated Lateral Raise (12-15)"
					],
					[
						"Dumbbell Seated Biceps Curl, Incline (15-20)",
						"Dumbbell Seated Overhead Triceps Ext (15-20)"
					],
					[
						"Dumbbell Wrist Curl (15-20)",
						"Dumbbell Wrist Extension (15-20)"
					]
				]
			}
		]
	};
}
