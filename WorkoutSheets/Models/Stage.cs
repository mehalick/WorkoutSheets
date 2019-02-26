using System.Collections.Generic;

namespace WorkoutSheets.Models
{
    public class Stage
    {
        public string Title { get; set; }
        public IEnumerable<string> Exercises { get; set; }
        public IEnumerable<int> SetsPerDay { get; set; }
        public IEnumerable<int> Supersets { get; set; } = new List<int>();
        public bool HighlightColumns { get; set; } = true;
    }
}
