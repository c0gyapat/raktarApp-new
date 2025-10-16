using RaktarApp.Common;
using RaktarApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarApp.Validators
{
    public static class NameValidator
    {
        public static void ValidateName(string name)
        {
            if (name is null)
                throw new ValidationExceptions(ErrorMessages.NameNull);

            var trimmed = name.Trim();
            if (trimmed.Length == 0)
                throw new ValidationExceptions(ErrorMessages.NameEmpty);

            if (trimmed.Length < 2)
                throw new ValidationExceptions(ErrorMessages.NameTooShort);

            foreach (var ch in trimmed)
            {
                if (!(char.IsLetter(ch) || ch == ' ' || ch == '-'))
                    throw new ValidationExceptions(ErrorMessages.NameInvalidChars);
            }
        }
    }
}
