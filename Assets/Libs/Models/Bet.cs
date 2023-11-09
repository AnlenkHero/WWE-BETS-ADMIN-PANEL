namespace Libs.Models 
{
    [System.Serializable]
    public class Bet
    {
        public string BetId;
        public string MatchId;
        public string ContestantId;
        public double BetAmount;
        public string UserId;
        public bool IsActive;
    }
}