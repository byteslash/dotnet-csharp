namespace Extensibility
{
    public class Human
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; private set; }

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

        public Human(string firstName, string lastName, string middleName = null)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void Initialize()
        {
            // private setters are not allowed outside of constructor
            //FirstName = "test";
            LastName = "test";
        }
    }
}