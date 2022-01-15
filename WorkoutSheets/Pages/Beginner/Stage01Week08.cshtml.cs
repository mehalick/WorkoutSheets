namespace WorkoutSheets.Pages.Beginner;

public class Stage01Week08Model : PageModel
{
	public Week Week = new()
	{
		Program = Models.Program.Beginner,
		Stage = 1,
		WeekRange = new(8, 10),
		PrintSize = PrintSize.Landscape,
		Workouts = new[]
		{
			new Workout
			{
				Letter = "A",
				ColumnsPerDay = new []{ 4, 4, 4 },
				SuperSets = new []
				{
					new[]
					{
						"Thin Tummy, Lift One Leg",
						"Curlup, Arms Straight & Parallel",
						"Side Raise",
						"Seated Thin Tummy + Cheek Squeeze"
					},
					new[]
					{
						"King Deadlift",
						"Single Leg Squat, Other Leg Out Front"
					},
					new[]
					{
						"Prone Hip-Thigh Extension",
						"Static Lunge, Back Foot on Low Block"
					},
					new []
					{
						"Single-Leg Stiff-Legged Deadlift",
						"Single-Leg Squat, on Low Block"
					},
					new []
					{
						"Leg Curl",
						"Leg Extension"
					},
					new []
					{
						"Seated Calf Raise",
						"Standing Single-Leg Calf Raise"
					},
					new []
					{
						"Dumbbell Shrug, Behind Body",
						"Dumbbell Shrug, To Front"
					}
				}
			},
			new Workout
			{
				Letter = "B",
				ColumnsPerDay = new []{ 4, 4, 4 },
				SuperSets = new []
				{
					new[]
					{
						"Toes to Sky",
						"Curlup, Legs in Air Arms Crossed",
						"Lateral Leg Lowering",
						"Pushup Hold, Lift Leg Then Arm"
					},
					new[]
					{
						"Seated Cable Row",
						"Barbell Bench Press, Feet on Bench"
					},
					new[]
					{
						"Reverse Dumbbell Fly",
						"Dumbbell Fly"
					},
					new []
					{
						"Lat Pulldown",
						"Barbell Seated Shoulder Press, To Front"
					},
					new []
					{
						"Dumbbell Lying Pullover, 1 Dumbbell",
						"Dumbbell Seated Lateral Raise"
					},
					new []
					{
						"Dumbbell Seated Biceps Curl, Incline",
						"Dumbbell Seated Overhead Triceps Ext"
					},
					new []
					{
						"Dumbbell Wrist Curl",
						"Dumbbell Wrist Extension"
					}
				}
			}
		}
	};
}
