using Ritam.Common.Result;
using Ritam.TimeManagement.Domain.Common.ValueObjects;
using Ritam.TimeManagement.Domain.People.Events;

namespace Ritam.TimeManagement.Domain.People.Models;
public partial class Person
{
    public static Result<Person> Create(string firstName, string lastName, string cardNumber)
    {
        Result<FirstNameValueObject> firstNameValue = FirstNameValueObject.Create(firstName);
        if (firstNameValue.IsFailure)
        {
            return Result.FromError<Person>(firstNameValue);
        }
        Result<LastNameValueObject> lastNameValue = LastNameValueObject.Create(lastName);
        if (lastNameValue.IsFailure)
        {
            return Result.FromError<Person>(lastNameValue);
        }

        Result<CardNumberValueObject> cardNumberValue = CardNumberValueObject.Create(cardNumber);
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
