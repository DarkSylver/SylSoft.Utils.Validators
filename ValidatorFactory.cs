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
        /// Validates if the input string is alphanumeric.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string contains only letters and numbers; otherwise, <c>false</c>.
        /// </returns>
        public static bool Alphanumeric(string input)
        {
            return new AlphanumericValidator().Validate(input);
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
        /// Validates if the input string is a valid Base64 string.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid Base64 string; otherwise, <c>false</c>.
        /// </returns>
        public static bool Base64(string input)
        {
            return new Base64Validator().Validate(input);
        }

        /// <summary>
        /// Validates if the input string is a valid credit card number.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid credit card number; otherwise, <c>false</c>.
        /// </returns>
        public static bool CreditCard(string input)
        {
            return new CreditCardValidator().Validate(input);
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
        /// Validates if the input string is a valid email address.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid email address; otherwise, <c>false</c>.
        /// </returns>
        public static bool Email(string input)
        {
            return new EmailValidator().Validate(input);
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
        /// Validates if the input string is a valid GUID.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid GUID; otherwise, <c>false</c>.
        /// </returns>
        public static bool Guid(string input)
        {
            return new GuidValidator().Validate(input);
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
        /// Validates if the input string is a valid hex color.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid hex color; otherwise, <c>false</c>.
        /// </returns>
        public static bool HexColor(string input)
        {
            return new HexColorValidator().Validate(input);
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
        /// Validates if the input string is a valid IBAN.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid IBAN; otherwise, <c>false</c>.
        /// </returns>
        public static bool IBAN(string input)
        {
            return new IBANValidator().Validate(input);
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
        /// Validates if the input string is a valid IP address.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid IP address; otherwise, <c>false</c>.
        /// </returns>
        public static bool Ip(string input)
        {
            return new IpValidator().Validate(input);
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
        /// Validates if the input string passes the Luhn algorithm.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string passes the Luhn algorithm; otherwise, <c>false</c>.
        /// </returns>
        public static bool Luhn(string input)
        {
            return new LuhnValidator().Validate(input);
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
        /// Validates if the input string is numeric.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool Numeric(string input)
        {
            return new NumericValidator().Validate(input);
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
        /// Validates if the input string meets password strength requirements.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string meets password strength requirements; otherwise, <c>false</c>.
        /// </returns>
        public static bool PasswordStrength(string input)
        {
            return new PasswordStrengthValidator().Validate(input);
        }

        /// <summary>
        /// Evaluates whether a given input string satisfies standard or customized password strength requirements.
        /// </summary>
        /// <remarks>
        /// This is a static convenience method intended to be called directly without instantiating a validator.
        /// Internally, it delegates the validation process to an instance of <see cref="PasswordStrengthValidator"/>.
        /// 
        /// The method supports customizable rules including:
        /// - Minimum required length
        /// - Whether uppercase, lowercase, digits, or special characters are required
        /// - Bypassing special character requirement for longer passphrases
        /// 
        /// If no parameters are provided, the method uses the default policy:
        /// Minimum 8 characters, at least one uppercase, one lowercase, one digit, and one special character
        /// (or 16+ characters to skip special requirement).
        /// </remarks>
        /// <param name="input">
        /// The password string to be validated. Cannot be null, empty, or consist solely of whitespace characters.
        /// </param>
        /// <param name="minimumLength">
        /// Optional. Defines the minimum number of characters required. Default is 8 if not provided.
        /// </param>
        /// <param name="specialCharLength">
        /// Optional. If the password is this length or longer, the special character requirement is skipped. Default is 16.
        /// </param>
        /// <param name="requireUpper">
        /// Optional. Indicates whether at least one uppercase character is mandatory. Default is true.
        /// </param>
        /// <param name="requireLower">
        /// Optional. Indicates whether at least one lowercase character is mandatory. Default is true.
        /// </param>
        /// <param name="requireSpecial">
        /// Optional. Indicates whether at least one special character is mandatory unless the password is long enough. Default is true.
        /// </param>
        /// <returns>
        /// Returns <c>true</c> if the password meets all applicable strength requirements; otherwise, returns <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The method does not directly throw this exception, but it delegates to <see cref="PasswordStrengthValidator.ValidateWithRules"/> which may reject null or whitespace inputs by returning false.
        /// </exception>
        public static bool PasswordStrength(string input,
            int? minimumLength = null,
            int? specialCharLength = null,
            bool? requireUpper = null,
            bool? requireLower = null,
            bool? requireSpecial = null)
        {
            // Delegate the validation to the PasswordStrengthValidator using the provided rules
            return new PasswordStrengthValidator().ValidateWithRules(
                input,
                minimumLength,
                specialCharLength,
                requireUpper,
                requireLower,
                requireSpecial);
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
        /// Gets the minimum length required for a strong password.
        /// </summary>
        /// <returns>
        /// Minimum length required for a strong password.
        /// </returns>
        public static int PasswordStrengthMinimumLength()
        {
            return PasswordStrengthValidator.GetMinimumLength();
        }

        /// <summary>
        /// Gets the minimum length required for a strong password.
        /// </summary>
        /// <returns>
        /// Minimum length required for a strong password.
        /// </returns>
        public static int PasswordStrengthSpecialCharLength()
        {
            return PasswordStrengthValidator.GetSpecialCharLength();
        }

        /// <summary>
        /// Validates if the input string is a valid phone number.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid phone number; otherwise, <c>false</c>.
        /// </returns>
        public static bool Phone(string input)
        {
            return new PhoneValidator().Validate(input);
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
        /// Validates if the input string is a valid URL.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the input string is a valid URL; otherwise, <c>false</c>.
        /// </returns>
        public static bool Url(string input)
        {
            return new UrlValidator().Validate(input);
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
        ///// Validates if the input string is a valid Alias CBU for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid Alias CBU; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool AliasCBU(string input)
        //{
        //    return new AliasCBUValidator().Validate(input);
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
        ///// Validates if the input string is a valid CBU for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CBU; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CBU(string input)
        //{
        //    return new CBUValidator().Validate(input);
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
        ///// Validates if the input string is a valid CUIL for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CUIL; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CUIL(string input)
        //{
        //    return new CUILValidator().Validate(input);
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
        ///// Validates if the input string is a valid CUIT for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CUIT; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CUIT(string input)
        //{
        //    return new CUITValidator().Validate(input);
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
        ///// Validates if the input string is a valid DNI for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid DNI; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool DNI(string input)
        //{
        //    return new DNIValidator().Validate(input);
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
        ///// Validates if the input string is a valid vehicle patent for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid vehicle patent; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool Patente(string input)
        //{
        //    return new PatenteValidator().Validate(input);
        //}

        ///// <summary>
        ///// Creates a phone number validation rule for Argentina.
        ///// </summary>
        ///// <returns>An instance of the <see cref="TelefonoValidator"/>.</returns>
        //public static IValidatorRule TelefonoAR()
        //{
        //    return new TelefonoValidator();
        //}

        ///// <summary>
        ///// Validates if the input string is a valid phone number for Argentina.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid phone number; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool TelefonoAR(string input)
        //{
        //    return new TelefonoValidator().Validate(input);
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
        ///// Validates if the input string is a valid CNPJ for Brazil.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CNPJ; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CNPJ(string input)
        //{
        //    return new CNPJValidator().Validate(input);
        //}

        ///// <summary>
        ///// Creates a CPF validation rule for Brazil.
        ///// </summary>
        ///// <returns>An instance of the <see cref="CPFValidator"/>.</returns>
        //public static IValidatorRule CPF()
        //{
        //    return new CPFValidator();
        //}

        ///// <summary>
        ///// Validates if the input string is a valid CPF for Brazil.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CPF; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CPF(string input)
        //{
        //    return new CPFValidator().Validate(input);
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
        ///// Validates if the input string is a valid CIF for Spain.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CIF; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CIF(string input)
        //{
        //    return new CIFValidator().Validate(input);
        //}

        ///// <summary>
        ///// Validates if the input string is a valid NIE for Spain.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid NIE; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool NIE(string input)
        //{
        //    return new NIEValidator().Validate(input);
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
        ///// Validates if the input string is a valid NIF for Spain.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid NIF; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool NIF(string input)
        //{
        //    return new NIFValidator().Validate(input);
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
        ///// Validates if the input string is a valid SSN for the USA.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid SSN; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool SSN(string input)
        //{
        //    return new SSNValidator().Validate(input);
        //}

        ///// <summary>
        ///// Validates if the input string is a valid ZIP code for the USA.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid ZIP code; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool ZipCodeUS(string input)
        //{
        //    return new ZipCodeValidator().Validate(input);
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
        ///// Validates if the input string is a valid postal code for Mexico.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid postal code; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CodigoPostalMX(string input)
        //{
        //    return new CodigoPostalValidator().Validate(input);
        //}

        ///// <summary>
        ///// Validates if the input string is a valid CURP for Mexico.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid CURP; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool CURP(string input)
        //{
        //    return new CURPValidator().Validate(input);
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
        ///// Validates if the input string is a valid RFC for Mexico.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid RFC; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool RFC(string input)
        //{
        //    return new RFCValidator().Validate(input);
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

        ///// <summary>
        ///// Validates if the input string is a valid RUT for Chile.
        ///// </summary>
        ///// <returns>
        ///// Returns <c>true</c> if the input string is a valid RUT; otherwise, <c>false</c>.
        ///// </returns>
        //public static bool RUT(string input)
        //{
        //    return new RUTValidator().Validate(input);
        //}

        //#endregion Chile Validators
    }
}