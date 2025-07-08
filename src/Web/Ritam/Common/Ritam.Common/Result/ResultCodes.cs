namespace Ritam.Common.Result;
public static class ResultCodes
{
    #region Common
    public const string InternalServerError = "INTERNAL_SERVER_ERROR";
    public const string FirstNameRequired = "FIRST_NAME_REQUIRED";
    public const string FirstNameInvalidLength = "FIRST_NAME_INVALID_LENGTH";
    public const string LastNameRequired = "LAST_NAME_REQUIRED";
    public const string LastNameInvalidLength = "LAST_NAME_INVALID_LENGTH";
    public const string CardNumberInvalidLength = "CARD_NUMBER_INVALID_LENGTH";
    public const string CardNumberRequired = "CARD_NUMBER_REQUIRED";
    public const string EmailRequired = "ENAIL_REQUIRED";
    public const string EmailInvalid = "EMAIL_INVALID";
    #endregion

    #region Tenant
    public const string TenantNameRequired = "TENANT_NAME_REQUIRED";
    public const string TenantNameInvalid = "TENANT_NAME_INVALID";
    #endregion

    #region Person
    #endregion

    #region Location
    public const string LocationNameInvalidLength = "LOCATION_NAME_INVALID_LENGTH";
    public const string LocationNameRequired = "LOCATION_NAME_REQUIRED";
    public const string LocationAddressInvalidLength = "LOCATION_ADDRESS_INVALID_LENGTH";
    public const string LocationAddressRequired = "LOCATION_ADDRESS_REQUIRED";
    #endregion

    #region Event
    #endregion
}
