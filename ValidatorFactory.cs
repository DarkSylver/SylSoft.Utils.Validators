using SylSoft.Utils.Validators.Core.Interfaces;
using SylSoft.Utils.Validators.Global;

namespace SylSoft.Utils.Validators
{
    /// <summary>
    /// SylSoft.Utils.Validators is a comprehensive library designed to provide easy-to-use validation tools for .NET applications.
    /// It features a wide range of validators, both for global formats (such as email, URL, phone number) and country-specific formats (e.g., CUIL, CPF, NIF, SSN, RUT).
    /// This library was developed by Cristian M. Zangaro at SylSoft, aiming to offer developers a lightweight, extensible, and offline solution to common validation needs.
    ///
    /// Key features include:
    /// - A flexible factory pattern that allows the instantiation of validators for multiple use cases.
    /// - Global validation rules (e.g., Email, URL, IP, Phone, etc.) for commonly used formats.
    /// - Country-specific validation rules tailored for Argentina, Brazil, Spain, the USA, Mexico, and Chile.
    /// - Date validation functionality to check leap years, first/last day of the month, and other date-related rules.
    /// - A modular design that supports future extensions and integration with other systems or validation rules.
    ///
    /// The library is fully offline and does not rely on any external APIs, making it suitable for scenarios where internet connectivity is not guaranteed.
    /// It is built using the latest .NET technologies, offering high performance and compatibility with .NET 6+ and C# 10+.
    ///
    /// The project is maintained by [Cristian M. Zangaro](https://github.com/DarkSylver) and supported by SylSoft, with ongoing development to add new validation rules and improve existing ones.
    /// </summary>

    public static class ValidatorFactory
    {
        #region Global Validators

        /// <summary>
        /// Creates an alphanumeric validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="AlphanumericValidator"/>.</returns>
        public static IValidatorRule Alphanumeric()
        {
            return new AlphanumericValidator();
        }

        /// <summary>
        /// Creates a base64 string validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="Base64Validator"/>.</returns>
        public static IValidatorRule Base64()
        {
            return new Base64Validator();
        }

        /// <summary>
        /// Creates a credit card validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="CreditCardValidator"/>.</returns>
        public static IValidatorRule CreditCard()
        {
            return new CreditCardValidator();
        }

        /// <summary>
        /// Creates a date validation service.
        /// </summary>
        /// <returns>An instance of the <see cref="DateService"/>.</returns>
        public static IDateValidationService Date()
        {
            return new DateService();
        }

        /// <summary>
        /// Creates an email validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="EmailValidator"/>.</returns>
        public static IValidatorRule Email()
        {
            return new EmailValidator();
        }

        /// <summary>
        /// Creates a GUID validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="GuidValidator"/>.</returns>
        public static IValidatorRule Guid()
        {
            return new GuidValidator();
        }

        /// <summary>
        /// Creates a hex color validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="HexColorValidator"/>.</returns>
        public static IValidatorRule HexColor()
        {
            return new HexColorValidator();
        }

        /// <summary>
        /// Creates an IBAN validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="IBANValidator"/>.</returns>
        public static IValidatorRule IBAN()
        {
            return new IBANValidator();
        }

        /// <summary>
        /// Creates an IP address validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="IpValidator"/>.</returns>
        public static IValidatorRule Ip()
        {
            return new IpValidator();
        }

        /// <summary>
        /// Creates a Luhn algorithm validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="LuhnValidator"/>.</returns>
        public static IValidatorRule Luhn()
        {
            return new LuhnValidator();
        }

        /// <summary>
        /// Creates a numeric validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="NumericValidator"/>.</returns>
        public static IValidatorRule Numeric()
        {
            return new NumericValidator();
        }

        /// <summary>
        /// Creates a password strength validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="PasswordStrengthValidator"/>.</returns>
        public static IValidatorRule PasswordStrength()
        {
            return new PasswordStrengthValidator();
        }

        /// <summary>
        /// Creates a phone number validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="PhoneValidator"/>.</returns>
        public static IValidatorRule Phone()
        {
            return new PhoneValidator();
        }

        /// <summary>
        /// Creates a URL validation rule.
        /// </summary>
        /// <returns>An instance of the <see cref="UrlValidator"/>.</returns>
        public static IValidatorRule Url()
        {
            return new UrlValidator();
        }

        #endregion Global Validators

        //#region Argentina Validators

        ///// <summary>
        ///// Creates an Alias CBU validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="AliasCBUValidator"/>.</returns>
        //public static IValidatorRule AliasCBU()
        //{
        //    return new AliasCBUValidator();
        //}

        ///// <summary>
        ///// Creates a CBU validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CBUValidator"/>.</returns>
        //public static IValidatorRule CBU()
        //{
        //    return new CBUValidator();
        //}

        ///// <summary>
        ///// Creates a CUIL validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CUILValidator"/>.</returns>
        //public static IValidatorRule CUIL()
        //{
        //    return new CUILValidator();
        //}

        ///// <summary>
        ///// Creates a CUIT validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CUITValidator"/>.</returns>
        //public static IValidatorRule CUIT()
        //{
        //    return new CUITValidator();
        //}

        ///// <summary>
        ///// Creates a DNI validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="DNIValidator"/>.</returns>
        //public static IValidatorRule DNI()
        //{
        //    return new DNIValidator();
        //}

        ///// <summary>
        ///// Creates a vehicle patent validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="PatenteValidator"/>.</returns>
        //public static IValidatorRule Patente()
        //{
        //    return new PatenteValidator();
        //}

        ///// <summary>
        ///// Creates a phone number validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="TelefonoValidator"/>.</returns>
        //public static IValidatorRule TelefonoAR()
        //{
        //    return new TelefonoValidator();
        //}

        //#endregion Argentina Validators

        //#region Brazil Validators

        ///// <summary>
        ///// Creates a CNPJ validation rule for Brazil.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CNPJValidator"/>.</returns>
        //public static IValidatorRule CNPJ()
        //{
        //    return new CNPJValidator();
        //}

        ///// <summary>
        ///// Creates a CPF validation rule for Brazil.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CPFValidator"/>.</returns>
        //public static IValidatorRule CPF()
        //{
        //    return new CPFValidator();
        //}

        //#endregion Brazil Validators

        //#region Spain Validators

        ///// <summary>
        ///// Creates a CIF validation rule for Spain.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CIFValidator"/>.</returns>
        //public static IValidatorRule CIF()
        //{
        //    return new CIFValidator();
        //}

        ///// <summary>
        ///// Creates a NIE validation rule for Spain.
        ///// </summary>
        ///// <returns>An instance of the <see cref="NIEValidator"/>.</returns>
        //public static IValidatorRule NIE()
        //{
        //    return new NIEValidator();
        //}

        ///// <summary>
        ///// Creates a NIF validation rule for Spain.
        ///// </summary>
        ///// <returns>An instance of the <see cref="NIFValidator"/>.</returns>
        //public static IValidatorRule NIF()
        //{
        //    return new NIFValidator();
        //}

        //#endregion Spain Validators

        //#region USA Validators

        ///// <summary>
        ///// Creates a SSN validation rule for the USA.
        ///// </summary>
        ///// <returns>An instance of the <see cref="SSNValidator"/>.</returns>
        //public static IValidatorRule SSN()
        //{
        //    return new SSNValidator();
        //}

        ///// <summary>
        ///// Creates a ZIP code validation rule for the USA.
        ///// </summary>
        ///// <returns>An instance of the <see cref="ZipCodeValidator"/>.</returns>
        //public static IValidatorRule ZipCodeUS()
        //{
        //    return new ZipCodeValidator();
        //}

        //#endregion USA Validators

        //#region Mexico Validators

        ///// <summary>
        ///// Creates a postal code validation rule for Mexico.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CodigoPostalValidator"/>.</returns>
        //public static IValidatorRule CodigoPostalMX()
        //{
        //    return new CodigoPostalValidator();
        //}

        ///// <summary>
        ///// Creates a CURP validation rule for Mexico.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CURPValidator"/>.</returns>
        //public static IValidatorRule CURP()
        //{
        //    return new CURPValidator();
        //}

        ///// <summary>
        ///// Creates an RFC validation rule for Mexico.
        ///// </summary>
        ///// <returns>An instance of the <see cref="RFCValidator"/>.</returns>
        //public static IValidatorRule RFC()
        //{
        //    return new RFCValidator();
        //}

        //#endregion Mexico Validators

        //#region Chile Validators

        ///// <summary>
        ///// Creates a RUT validation rule for Chile.
        ///// </summary>
        ///// <returns>An instance of the <see cref="RUTValidator"/>.</returns>
        //public static IValidatorRule RUT()
        //{
        //    return new RUTValidator();
        //}

        //#endregion Chile Validators
    }
}