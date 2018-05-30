namespace WorkoutSheets.Models
{
    public class Stage
    {
        public string Title { get; set; }
        public int Weeks { get; set; } = 3;
        public int DaysPerWeek { get; set; } = 3;
        public int[] Sets { get; set; }
        public int[] Repeats { get; set; }
        public string[] Exercises { get; set; }
        public int[] Supersets { get; set; }
    }
}
