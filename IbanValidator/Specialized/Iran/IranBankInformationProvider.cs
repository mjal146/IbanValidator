using System.Collections.Generic;
using System.Linq;

namespace IbanValidator.Specialized.Iran
{
    /// <summary>
    /// 
    /// </summary>
    public static class IranBankInformationProvider
    {
        private static readonly List<BankInformation> Banks = new List<BankInformation>
            {
                new BankInformation
                {
                    NickName = "central-bank",
                    Name = "Central Bank of Iran",
                    PersianName = "بانک مرکزی جمهوری اسلامی ایران",
                    Code = "010",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "sanat-o-madan",
                    Name = "Sanat O Madan Bank",
                    PersianName = "بانک صنعت و معدن",
                    Code = "011",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "mellat",
                    Name = "Mellat Bank",
                    PersianName = "بانک ملت",
                    Code = "012",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "refah",
                    Name = "Refah Bank",
                    PersianName = "بانک رفاه کارگران",
                    Code = "013",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "maskan",
                    Name = "Maskan Bank",
                    PersianName = "بانک مسکن",
                    Code = "014",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "sepah",
                    Name = "Sepah Bank",
                    PersianName = "بانک سپه",
                    Code = "015",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "keshavarzi",
                    Name = "Keshavarzi",
                    PersianName = "بانک کشاورزی",
                    Code = "016",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "melli",
                    Name = "Melli",
                    PersianName = "بانک ملی ایران",
                    Code = "017",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "tejarat",
                    Name = "Tejarat Bank",
                    PersianName = "بانک تجارت",
                    Code = "018",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "saderat",
                    Name = "Saderat Bank",
                    PersianName = "بانک صادرات ایران",
                    Code = "019",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "tosee-saderat",
                    Name = "Tose Saderat Bank",
                    PersianName = "بانک توسعه صادرات",
                    Code = "020",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "post",
                    Name = "Post Bank",
                    PersianName = "پست بانک ایران",
                    Code = "021",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "toose-taavon",
                    Name = "Tosee Taavon Bank",
                    PersianName = "بانک توسعه تعاون",
                    Code = "022",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "tosee",
                    Name = "Tosee Bank",
                    PersianName = "موسسه اعتباری توسعه",
                    Code = "051",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "ghavamin",
                    Name = "Ghavamin Bank",
                    PersianName = "بانک قوامین",
                    Code = "052",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "karafarin",
                    Name = "Karafarin Bank",
                    PersianName = "بانک کارآفرین",
                    Code = "053",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "parsian",
                    Name = "Parsian Bank",
                    PersianName = "بانک پارسیان",
                    Code = "054",
                    AccountNumberAvailable = true,
                },
                new BankInformation
                {
                    NickName = "eghtesad-novin",
                    Name = "Eghtesad Novin Bank",
                    PersianName = "بانک اقتصاد نوین",
                    Code = "055",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "saman",
                    Name = "Saman Bank",
                    PersianName = "بانک سامان",
                    Code = "056",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "pasargad",
                    Name = "Pasargad Bank",
                    PersianName = "بانک پاسارگاد",
                    Code = "057",
                    AccountNumberAvailable = true,
                },
                new BankInformation
                {
                    NickName = "sarmayeh",
                    Name = "Sarmayeh Bank",
                    PersianName = "بانک سرمایه",
                    Code = "058",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "sina",
                    Name = "Sina Bank",
                    PersianName = "بانک سینا",
                    Code = "059",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "mehr-iran",
                    Name = "Mehr Iran Bank",
                    PersianName = "بانک مهر ایران",
                    Code = "060",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "shahr",
                    Name = "City Bank",
                    PersianName = "بانک شهر",
                    Code = "061",
                    AccountNumberAvailable = true,
                },
                new BankInformation
                {
                    NickName = "ayandeh",
                    Name = "Ayandeh Bank",
                    PersianName = "بانک آینده",
                    Code = "062",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "ansar",
                    Name = "Ansar Bank",
                    PersianName = "بانک انصار",
                    Code = "063",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "gardeshgari",
                    Name = "Gardeshgari Bank",
                    PersianName = "بانک گردشگری",
                    Code = "064",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "hekmat-iranian",
                    Name = "Hekmat Iranian Bank",
                    PersianName = "بانک حکمت ایرانیان",
                    Code = "065",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "dey",
                    Name = "Dey Bank",
                    PersianName = "بانک دی",
                    Code = "066",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "iran-zamin",
                    Name = "Iran Zamin Bank",
                    PersianName = "بانک ایران زمین",
                    Code = "069",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "resalat",
                    Name = "Resalat Bank",
                    PersianName = "بانک قرض الحسنه رسالت",
                    Code = "070",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "mehr-iran",
                    Name = "Mehr Iran Bank",
                    PersianName = "بانک مهر ایران",
                    Code = "090",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "iran-venezuela",
                    Name = "Iran and Venezuela Bank",
                    PersianName = "بانک ایران و ونزوئلا",
                    Code = "095",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "middle-east",
                    Name = "Middle East Bank",
                    PersianName = "بانک خاورمیانه",
                    Code = "078",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "melal",
                    Name = "Credit Institution of Melal",
                    PersianName = "موسسه اعتباری ملل",
                    Code = "075",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "noor",
                    Name = "Credit Institution of Noor",
                    PersianName = "موسسه اعتباری نور",
                    Code = "080",
                    AccountNumberAvailable = false
                },
                new BankInformation
                {
                    NickName = "middle-east-bank",
                    Name = "Middle East Bank",
                    PersianName = "بانک خاورمیانه",
                    Code = "078",
                    AccountNumberAvailable = false
                }
            };

        /// <summary>
        /// دریافت اطلاعات بانک
        /// </summary>
        /// <param name="iban"></param>
        /// <returns></returns>
        public static BankInformation GetBankInformation(this Iban iban)
        {
            return Banks.FirstOrDefault(a => a.Code == iban.Bban.Substring(0, 3));
        }
    }
}
