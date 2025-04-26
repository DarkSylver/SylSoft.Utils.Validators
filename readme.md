# SylSoft.Utils.Validators

A modular, extensible, and lightweight set of validators for .NET developers.  
Covers global and country-specific validation rules without relying on any external services.

---

## ✨ Features

- Global validators (Email, IP, URL, GUID, IBAN, etc.)
- Country-specific validators (Argentina, Brazil, Spain, USA, Mexico, Chile)
- Fluent and intuitive API
- Full C# 10+ and .NET 6+ support
- 100% offline, no external dependencies
- Designed for extensibility

---

## 🚀 Installation

```bash
dotnet add package SylSoft.Utils.Validators
```

Or via NuGet Package Manager:

```
Install-Package SylSoft.Utils.Validators
```

---

## 📚 Usage

```csharp
using SylSoft.Utils.Validators;

// Email validation
var emailValidator = ValidatorFactory.Email();
bool isValidEmail = emailValidator.Validate("example@domain.com");

// Validate CUIL (Argentina)
var cuilValidator = ValidatorFactory.CUIL();
bool isValidCuil = cuilValidator.Validate("20-12345678-3");

// Date validations
var dateService = ValidatorFactory.Date();
bool isLeapYear = dateService.IsLeapYear(2024);
bool isFirstDayOfMonth = dateService.IsFirstDayOfMonth(DateTime.Today);
```

---

## 🛆 Available Validators

### Global
- EmailValidator
- UrlValidator
- IpValidator
- PhoneValidator
- PasswordStrengthValidator
- GuidValidator
- IBANValidator
- CreditCardValidator
- Base64Validator
- HexColorValidator
- AlphanumericValidator
- NumericValidator
- LuhnValidator
- DateValidator (and Date service)

### Argentina
- CUILValidator
- CUITValidator
- DNIValidator
- CBUValidator
- AliasCBUValidator
- PatenteValidator
- TelefonoValidator

### Brazil
- CPFValidator
- CNPJValidator

### Spain
- NIFValidator
- NIEValidator
- CIFValidator

### USA
- SSNValidator
- ZipCodeValidator

### Mexico
- RFCValidator
- CURPValidator
- CodigoPostalValidator

### Chile
- RUTValidator

---

## 🛡️ License

This project is licensed under the [MIT License](LICENSE).

---

## ❤️ Support

If you find this library useful, consider sponsoring the project to help continue development!  
[Become a Sponsor ✨](https://github.com/sponsors/YourUsername)

---

## 🌍 About

Developed by [Cristian M. Zangaro](https://github.com/DarkSylver) at [SylSoft](https://github.com/SylSoft-Software-Design).

---

# LICENSE

MIT License

Copyright (c) 2025 Cristian M. Zangaro

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
