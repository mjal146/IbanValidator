#ibanValidator
==============
بررسی صحت شماره شبا و دریافت اطلاعات بانکی مرتبط
 

Install

     Install-Package IbanValidator
Or

     <PackageReference Include="IbanValidator" Version="2.0.0" />

A small library used for IBAN and BBAN validation.

Example usage:

    // Parse:
    iban = Iban.Parse("IR86 0160 0000 0000 0838 4");
    Console.WriteLine(iban.IsValid);

    // TryParse:
    if(Iban.TryParse("IR86 0160 0000 0000 0838 4", out iban))
    {
        Console.WriteLine(iban.IsValid);
    }
    
    //TryParse and check is valid or not
    Iban iban;
    if (!Iban.TryParse("IRIR8601600000000008384", out iban)&&!iban.IsValid)
    {
        Console.WriteLine("iban Is Valid");
    }
    
```

Acknowledgment
--------------
https://github.com/nikeee/iban-validator
