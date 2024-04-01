﻿namespace Libs.Models.RequestModels
{
    [System.Serializable]
    public class BetRequest
    {
        public int MatchId;
        public int ContestantId;
        public double BetAmount;
        public string UserId;
        public bool IsActive;
    }
}