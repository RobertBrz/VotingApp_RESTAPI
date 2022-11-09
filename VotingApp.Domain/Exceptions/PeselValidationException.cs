using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Domain.Exceptions
{
    internal class PeselValidationException : Exception
    {
        public PeselValidationException() : base()
        {

        }
    }
}
