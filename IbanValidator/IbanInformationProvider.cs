using System;

namespace IbanValidator
{
    public abstract class IbanInformationProvider
    {
        protected readonly Iban IbanInternal;
        public Iban Iban => IbanInternal;

        protected IbanInformationProvider(Iban iban)
        {
            if (iban == null)
                throw new ArgumentNullException(nameof(iban));
            IbanInternal = iban;
        }
    }
}
