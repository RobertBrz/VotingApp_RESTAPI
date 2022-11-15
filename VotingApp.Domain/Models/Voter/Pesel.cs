using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Voters.Domain.Exceptions;

namespace VotingApp.Voters.Domain.Models.Voter
{
    public class Pesel
    {
        public long Number { get; set; }

        void Validation()
        {
            if (!(Number.ToString().Count() == 9)) throw new PeselValidationException();
        }
    }
}
