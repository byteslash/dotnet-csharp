namespace Extensibility
{
    public abstract class CulturedHuman
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public virtual string Title
        {
            get
            {
                var title = Position switch
                {
                    JobPosition.Apprentice => "Genin",
                    JobPosition.Junior => "Chuunin",
                    JobPosition.Expert => "Jonin",
                    _ => "Genin"
                };
                return title;

                /*
                switch (Position)
                {
                    case JobPosition.Apprentice: Title = "Genin"; break;
                    case JobPosition.Junior: Title = "Chuunin"; break;
                    case JobPosition.Expert: Title = "Jonin"; break;
                }
                */
            }
        }
        public string Initials
        {
            get
            {
                var initials = FirstName.Trim().Substring(0, 1);
                if (!string.IsNullOrEmpty(MiddleName))
                {
                    initials += MiddleName.Trim().Substring(0, 1);
                }
                initials += LastName.Trim().Substring(0, 1);
                return initials;
            }
        }

        protected JobPosition Position { get; }

        public CulturedHuman(string firstName, string lastName, string middleName = null, JobPosition position = JobPosition.Apprentice)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Position = position;
        }
    }

    public enum JobPosition
    {
        Apprentice = 0,
        Junior = 1,
        Expert = 2
    }
}