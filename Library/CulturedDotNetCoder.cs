namespace Extensibility
{
    public sealed class CulturedDotNetCoder : CulturedHuman, ICoder, ICodingAbility
    {
        public CulturedDotNetCoder(string favLanguage, int wpm, string frwVersion, string firstName, string lastName, string middleName = null, JobPosition position = JobPosition.Apprentice)
        : base(firstName, lastName, middleName, position)
        {
            HighestKnownDotNetFrwVersion = frwVersion;
            FavouriteLanguage = favLanguage;
            WordsPerMinute = wpm;
        }

        public override string Title
        {
            get
            {
                return "Hokage";
            }
        }

        public string HighestKnownDotNetFrwVersion { get; }

        public int WordsPerMinute { get; }

        public string FavouriteLanguage { get; }
    }
}