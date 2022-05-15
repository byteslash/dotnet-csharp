namespace Extensibility
{
    public sealed class CulturedCoder : CulturedHuman
    {

        public CulturedCoder(string firstName, string lastName, string middleName = null, JobPosition position = JobPosition.Apprentice)
        : base(firstName, lastName, middleName, position)
        {

        }

        public override string Title
        {
            get
            {
                return "Hokage";
            }
        }
        // public new string Title
        // {
        //     get
        //     {
        //         return "Hokage";
        //     }
        // }
    }
}