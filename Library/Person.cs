namespace Extensibility
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Initials { get; set; }

        public string ShortName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}