using System.Reflection.Metadata.Ecma335;

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

        public SupervisoryLevel Level
        {
            get { return _Level; }
            private set
            {
                if (!Enum.IsDefined(typeof(SupervisoryLevel), value))
                {
                    throw new ArgumentException($"Supervisory level is invalid: {value}");
                }
                _Level = value;
            }
        }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (!Utilities.IsZeroOrPositive(value))
                {
                    throw new ArgumentOutOfRangeException(value.ToString());
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

            if (years > 0.0)
            {
                Years = (double)years;
            }
            else
            {
                TimeSpan span = DateTime.Now - StartDate;
                Years = Math.Round((span.Days / 365.25), 1);
            }
        }

        public void SetEmploymentResponsibilityLevel(SupervisoryLevel level)
        {
            Level = level;
        }

        public void CorrectStartDate(DateTime startdate)
        {
            if (startdate >= DateTime.Today.AddDays(1))
            {
                throw new ArgumentException($"The startdate {startdate} is in the future");
            }
            StartDate = startdate;
        }

        public double UpdateCurrentEmploymentYearsExperience()
        {
            TimeSpan span = DateTime.Now - StartDate;
            Years = Math.Round((span.Days / 365.25), 1);
            return Years;
        }
        
        public override string ToString()
        {
            return $"{Title}, {Level}, {StartDate.ToString("MMM dd, yyyy")}, {Years}";
        }
    }
}