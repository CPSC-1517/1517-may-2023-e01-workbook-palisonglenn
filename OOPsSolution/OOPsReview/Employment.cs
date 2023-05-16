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
    }
}