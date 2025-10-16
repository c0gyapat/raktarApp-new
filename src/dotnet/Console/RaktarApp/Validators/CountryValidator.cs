using RaktarApp.Common;
using RaktarApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarApp.Validators
{
    public static class CountryValidator
    {
        public static void ValidateCountry(string country)
        {
            if (country is null)
                throw new ValidationExceptions(ErrorMessages.CountryNull);

            var trimmed = country.Trim();
            if (trimmed.Length == 0)
                throw new ValidationExceptions(ErrorMessages.CountryEmpty);

            if (trimmed.Length < 2)
                throw new ValidationExceptions(ErrorMessages.CountryTooShort);

            foreach (var ch in trimmed)
            {
                if (!(char.IsLetter(ch) || ch == ' ' || ch == '-'))
                    throw new ValidationExceptions(ErrorMessages.CountryInvalidChars);
            }
        }
    }
}
