namespace TeamInterface
{
    public class SubTeam : Team
    {
        public SubTeam(string teamName, int noOfPlayers) 
            : base(teamName, noOfPlayers)
        {
        }

        public void ChangeName(string name)
        {
            teamName = name;
        }
    }
}