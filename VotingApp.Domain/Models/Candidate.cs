using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using VotingApp.Domain.Models.Interfaces;

namespace VotingApp.Domain.Models
{
    [Index("Pesel", IsUnique = true, Name = "PeselIndex")]
    public class Candidate : ICandidate
    {
        public int Id { get; set; }
        public long Pesel { get; set; }
        public string Name { get; set; }
        public int Votes { get; set; } = 0;

        public void AddVote()
        {
            Votes++;
        }

        public ICandidate GetInstance()
        {
            return this;
        }

        public long GetPesel()
        {
            return Pesel;
        }
    }
}
