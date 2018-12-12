#ibanValidator
==============

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
```

Acknowledgment
--------------
https://github.com/nikeee/iban-validator
