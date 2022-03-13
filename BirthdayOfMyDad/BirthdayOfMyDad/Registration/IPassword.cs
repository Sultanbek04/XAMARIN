using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayOfMyDad.Registration
{
  interface IPassword
  {
    (bool isValidPassword, IEnumerable<string> onValidationErrors)
    ValidatePasswordInput(string password);
  }

  class BasicValidation : IPassword
  {
    private int MinLength = 8;
    private int MaxLength = 100;
    private readonly char[] _requiredOneOfTheseSymbols = "!@#$%^&*".ToCharArray();
    private readonly char[] _upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private const string _requiredLength = "Minimum length required 8 and maximum 100";
    private const string _requiredSymbol = "At least 1 special symbol required";
    private const string _requiredUpperSymbol = "At least 1 upper symbol required";



    public (bool isValidPassword, IEnumerable<string> onValidationErrors)
           ValidatePasswordInput(string password)
    {
      var onValidationErrors = new List<string>();

      if (password.Length > MaxLength || password.Length < MinLength)
      {
        onValidationErrors.Add(_requiredLength);
      }

      if (!_requiredOneOfTheseSymbols.Any(s => password.Contains(s)))
      {
        onValidationErrors.Add(_requiredSymbol);
      }

      if (!_upperLetters.Any(s => password.Contains(s)))
      {
        onValidationErrors.Add(_requiredUpperSymbol);
      };

      return (!onValidationErrors.Any(), onValidationErrors);
    }
  }
}
