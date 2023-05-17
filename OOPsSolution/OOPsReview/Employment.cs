namespace OOPsReview
{
    public class Employment
    {
        // Private members for the class
        private SupervisoryLevel _Level;
        private string _Title;
        private double _Years;

        // Public properties for the class
        public string Title
        {
            get { return _Title; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is required");
                }
                _Title = value;
            }
        }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (!Utilities.IsZeroOrPositive(value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _Years = value;
            }
        }

        public DateTime StartDate { get; private set; }

        public Employment()
        {
            Title = "Unknown";
            Level = SupervisoryLevel.TeamMember;
            StartDate = DateTime.Today;
        }

        public Employment(string title, SupervisoryLevel level, DateTime startdate, double years = 0.0)
        {
            Title = title;
            Level = level;
            Years = years;  
            if (startdate >= DateTime.Today.AddDays(1)) 
            {
                throw new ArgumentException($"The start date {startdate} is in the future!");
            }
            StartDate = startdate;
        }
    }
}