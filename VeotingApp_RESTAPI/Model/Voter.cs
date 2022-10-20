﻿using System.Security;

namespace VotingApp_RESTAPI.Model
{
    public class Voter :IVoter
    {
        public string Name { get; set; }
        public bool HasVoted { get; set; }

        public void SetAsVoted(bool voted =  true)
        {
            HasVoted = voted;
        }
    }
}
