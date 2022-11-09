using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using VotingApp.Domain.Models.Interfaces;

namespace VotingApp.Domain.Models
{
    [Index("Pesel", IsUnique = true, Name = "PeselIndex")]
    public class Candidate : ICandidate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Pesel { get; set; }

        [Required]
        public string Name { get; set; }

        public int Votes { get; set; } = 0;

        public void AddVote()
        {
            Votes++;
        }

        public Candidate GetInstance()
        {
            return this;
        }

        public long GetPesel()
        {
            return Pesel;
        }
    }
}
