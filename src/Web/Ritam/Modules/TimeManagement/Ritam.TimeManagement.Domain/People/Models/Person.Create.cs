using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.People.Events;

namespace Ritam.TimeManagement.Domain.People.Models;
public partial class Person
{
    private static Result<string> CreateFirstNameValue(string firstName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameRequired);
        }

        if (firstName.Length < 2 || firstName.Length > 100)
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameInvalidLength);
        }

        return Result.Ok(firstName);
    }
    
    private static Result<string> CreateLastNameValue(string lastName)
    {
        if (string.IsNullOrEmpty(lastName))
        {
            return Result.Invalid<string>(ResultCodes.PersonLastNameRequired);
        }

        if (lastName.Length < 2 || lastName.Length > 100)
        {
            return Result.Invalid<string>(ResultCodes.PersonLastNameInvalidLength);
        }

        return Result.Ok(lastName);
    }

    private static Result<string> CreateCardNumberValue(string cardNumber)
    {
        if (string.IsNullOrEmpty(cardNumber))
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameRequired);
        }

        if (cardNumber.Length < 2 || cardNumber.Length > 100)
        {
            return Result.Invalid<string>(ResultCodes.PersonFirstNameInvalidLength);
        }

        return Result.Ok(cardNumber);
    }

    public static Result<Person> Create(string firstName, string lastName, string cardNumber)
    {
        Result<string> firstNameValue = CreateFirstNameValue(firstName);
        if (firstNameValue.IsFailure)
        {
            return Result.FromError<Person>(firstNameValue);
        }
        Result<string> lastNameValue = CreateLastNameValue(lastName);
        if (lastNameValue.IsFailure)
        {
            return Result.FromError<Person>(lastNameValue);
        }
        Result<string> cardNumberValue = CreateCardNumberValue(cardNumber);
        if (cardNumberValue.IsFailure)
        {
            return Result.FromError<Person>(cardNumberValue);
        }

        Person person = new Person
        {
            Uid = Guid.NewGuid(),
            FirstName = firstNameValue.Value,
            LastName = lastNameValue.Value,
            CardNumber = cardNumberValue.Value,
        };

        person.AddDomainEvent(new PersonCreatedDomainEvent(person));
        return Result.Ok(person);
    }
}
