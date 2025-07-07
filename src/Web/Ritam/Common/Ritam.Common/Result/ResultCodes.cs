namespace Ritam.Common.Result;
public static class ResultCodes
{
    #region Common
    public const string InternalServerError = "INTERNAL_SERVER_ERROR";
    #endregion

    #region Tenant
    public const string TenantNameRequired = "TENANT_NAME_REQUIRED";
    public const string TenantNameInvalid = "TENANT_NAME_INVALID";
    public const string TenantEmailRequired = "TENANT_ENAIL_REQUIRED";
    public const string TenantEmailInvalid = "TENANT_EMAIL_INVALID";
    #endregion

    #region Person
    public const string PersonFirstNameRequired = "PERSON_FIRST_NAME_REQUIRED";
    public const string PersonFirstNameInvalidLength = "PERSON_FIRST_NAME_INVALID_LENGTH";
    public const string PersonLastNameRequired = "PERSON_LAST_NAME_REQUIRED";
    public const string PersonLastNameInvalidLength = "PERSON_LAST_NAME_INVALID_LENGTH";
    #endregion

    #region Location
    public const string LocationNameInvalidLength = "LOCATION_NAME_INVALID_LENGTH";
    public const string LocationNameRequired = "LOCATION_NAME_REQUIRED";
    public const string LocationAddressInvalidLength = "LOCATION_ADDRESS_INVALID_LENGTH";
    public const string LocationAddressRequired = "LOCATION_ADDRESS_REQUIRED";
    #endregion

    #region Event
    public const string EventCardNumberInvalidLength = "EVENT_CARD_NUMBER_INVALID_LENGTH";
    public const string EventCardNumberRequired = "EVENT_CARD_NUMBER_REQUIRED";
    #endregion
}
