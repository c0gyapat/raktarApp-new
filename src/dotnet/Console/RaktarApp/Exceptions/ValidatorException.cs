using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarApp.Exceptions
{
    public sealed class ValidationExceptions : System.Exception
    {
        public ValidationExceptions(string message) : base(message) { }
    }
}
