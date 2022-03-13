using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BirthdayOfMyDad.Registration
{
  interface IPhoneNumber
  {
    (bool isValidPhoneNumber, IEnumerable<string> onValidationErrors)
    ValidatePhoneNumberInput(string phoneNumber);
  }

  public class BasePhoneNumberValidator : IPhoneNumber
  {
    private readonly Regex _phoneNumberRegex;
    private const string _onRegexInvalidErrorMessage =
        "Номер не соответствует паттерну валидации";
    private const string _onPhoneNumberMaxLengthExceeded =
        "Номер телефона слишком длинный";
    private const int PhoneNumberMaxLength = 13;

    

    public (bool isValidPhoneNumber, IEnumerable<string> onValidationErrors)
        ValidatePhoneNumberInput(string phoneNumber)
    {
      var onValidationErrors = new List<string>();

      if (phoneNumber.Length > PhoneNumberMaxLength)
      {
        onValidationErrors.Add(_onPhoneNumberMaxLengthExceeded);
      }
      return (!onValidationErrors.Any(), onValidationErrors);
    }
  }

}

