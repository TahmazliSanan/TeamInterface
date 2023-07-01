namespace TeamInterface
{
    public class Team
    {
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            noOfPlayers -= count;
            if (noOfPlayers < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}