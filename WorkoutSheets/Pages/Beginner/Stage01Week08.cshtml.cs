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
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					[
						"Thin Tummy, Lift One Leg",
						"Curlup, Arms Straight & Parallel",
						"Side Raise",
						"Seated Thin Tummy + Cheek Squeeze"
					],
					[
						"King Deadlift",
						"Single Leg Squat, Other Leg Out Front"
					],
					[
						"Prone Hip-Thigh Extension",
						"Static Lunge, Back Foot on Low Block"
					],
					[
						"Single-Leg Stiff-Legged Deadlift",
						"Single-Leg Squat, on Low Block"
					],
					[
						"Leg Curl",
						"Leg Extension"
					],
					[
						"Seated Calf Raise",
						"Standing Single-Leg Calf Raise"
					],
					[
						"Dumbbell Shrug, Behind Body",
						"Dumbbell Shrug, To Front"
					]
				]
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = [4, 4, 4],
				SuperSets =
				[
					[
						"Toes to Sky",
						"Curlup, Legs in Air Arms Crossed",
						"Lateral Leg Lowering",
						"Pushup Hold, Lift Leg Then Arm"
					],
					[
						"Seated Cable Row",
						"Barbell Bench Press, Feet on Bench"
					],
					[
						"Reverse Dumbbell Fly",
						"Dumbbell Fly"
					],
					[
						"Lat Pulldown",
						"Barbell Seated Shoulder Press, To Front"
					],
					[
						"Dumbbell Lying Pullover, 1 Dumbbell",
						"Dumbbell Seated Lateral Raise"
					],
					[
						"Dumbbell Seated Biceps Curl, Incline",
						"Dumbbell Seated Overhead Triceps Ext"
					],
					[
						"Dumbbell Wrist Curl",
						"Dumbbell Wrist Extension"
					]
				]
			}
		]
	};
}
