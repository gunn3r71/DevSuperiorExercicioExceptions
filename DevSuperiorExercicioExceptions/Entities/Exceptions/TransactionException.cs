using System;
using System.Collections.Generic;
using System.Text;

namespace DevSuperiorExercicioExceptions.Entities.Exceptions
{
    class TransactionException : ApplicationException
    {
        public TransactionException(string message) : base(message)
        {
        }
    }
}
