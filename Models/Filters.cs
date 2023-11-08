using Microsoft.VisualBasic;

namespace ToDo.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            filterstring = filterstring ?? "all-all-all";
            string[] filters = filterstring.Split('-');
            CategoryId = filters[0];
            Due = filters[1];
            StatusId = "all";
        }

        public string FilterString { get; }
        public string CategoryId { get; }
        public string Due { get; } 
        public string StatusId { get; }
        public bool HasCategory => CategoryId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";
        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string>
            {
                {"future","Future" },
                {"past", "Past"},
                {"today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";
    }
}
