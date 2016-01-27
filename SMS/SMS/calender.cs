using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class calender
    {       
        public static string Bday { get; set; }
        public string Aday { get; set; }

        //Get Bangla date and month
        public string BanglaDate(int month, int day)
        {
            //Januray
            if (month == 1)
            {
                if (day >= 01 & day <= 13)
                {
                    Bday = "pou" + (18 + day - 1);
                }
                else if (day >= 14 & day <= 31)
                {
                    Bday = "mag" + (day - 13);
                }
            }
            //February
            else if (month == 02)
            {
                if (day >= 01 & day <= 12)
                {
                    Bday = "mag" + (19 + day - 1);
                }
                else if (day >= 13 & day <= 28)
                {
                    Bday = "fal" + (day - 12);
                }
            }
            //March
            else if (month == 03)
            {
                if (day >= 01 & day <= 14)
                {
                    Bday = "fal" + (17 + day - 1);
                }
                else if (day >= 15 & day <= 31)
                {
                    Bday = "cai" + (day - 14);
                }
            }
            //April
            else if (month == 04)
            {
                if (day >= 01 & day <= 13)
                {
                    Bday = "cai" + (18 + day - 1);
                }
                else if (day >= 14 & day <= 30)
                {
                    Bday = "bai" + (day - 13);
                }
            }
            //May
            else if (month == 05)
            {
                if (day >= 01 & day <= 14)
                {
                    Bday = "bai" + (18 + day - 1);
                }
                else if (day >= 15 & day <= 31)
                {
                    Bday = "jai" + (day - 14);
                }
            }
            //June
            else if (month == 06)
            {
                if (day >= 01 & day <= 14)
                {
                    Bday = "jai" + (18 + day - 1);
                }
                else if (day >= 15 & day <= 30)
                {
                    Bday = "asr" + (day - 14);
                }
            }
            //July
            else if (month == 07)
            {
                if (day >= 01 & day <= 15)
                {
                    Bday = "asr" + (17 + day - 1);
                }
                else if (day >= 16 & day <= 31)
                {
                    Bday = "sra" + (day - 15);
                }
            }
            //August
            else if (month == 08)
            {
                if (day >= 01 & day <= 15)
                {
                    Bday = "sra" + (17 + day - 1);
                }
                else if (day >= 14 & day <= 31)
                {
                    Bday = "vad" + (day - 15);
                }
            }
            //September
            else if (month == 09)
            {
                if (day >= 01 & day <= 15)
                {
                    Bday = "vad" + (17 + day - 1);
                }
                else if (day >= 16 & day <= 30)
                {
                    Bday = "ars" + (day - 15);
                }
            }
            //October
            else if (month == 10)
            {
                if (day >= 01 & day <= 15)
                {
                    Bday = "ars" + (16 + day - 1);
                }
                else if (day >= 16 & day <= 31)
                {
                    Bday = "kar" + (day - 15);
                }
            }
            //November
            else if (month == 11)
            {
                if (day >= 01 & day <= 14)
                {
                    Bday = "kar" + (17 + day - 1);
                }
                else if (day >= 15 & day <= 30)
                {
                    Bday = "agr" + (day - 14);
                }
            }
            //December
            else if (month == 12)
            {
                if (day >= 01 & day <= 14)
                {
                    Bday = "agr" + (17 + day - 1);
                }
                else if (day >= 15 & day <= 31)
                {
                    Bday = "pou" + (day - 14);
                }
            }

            return Bday;
        }

        public string ArabicDate(int month, int day)
        {
            //Januray
            if (month == 01)
            {
                if (day >= 01 & day <= 02)
                {
                    Aday = "saf" + (28 + day - 1);
                }
                else if (day >= 03 & day <= 31)
                {
                    Aday = "raa" + (day - 2);
                }
            }
            //February
            else if (month == 02)
            {
                if (day == 01)
                {
                    Aday = "raa" + 30;
                }
                else if (day >= 02 & day <= 28)
                {
                    Aday = "rus" + (day - 1);
                }
            }
            //March
            else if (month == 03)
            {
                if (day >= 01 & day <= 02)
                {
                    Aday = "rus" + (28 + day - 1);
                }
                else if (day >= 03 & day <= 31)
                {
                    Aday = "jua" + (day - 2);
                }
            }
            //April
            else if (month == 04)
            {
                if (day == 01)
                {
                    Aday = "jua" + 30;
                }
                else if (day >= 2 & day <= 30)
                {
                    Aday = "jus" + (day - 1);
                }
            }
            //May
            else if (month == 05)
            {
                if (day >= 01 & day <= 30)
                {
                    Aday = "raj" + day;
                }
                else if (day == 31)
                {
                    Aday = "sha" + 1;
                }
            }
            //June
            else if (month == 06)
            {
                if (day >= 01 & day <= 29)
                {
                    Aday = "sha" + (2 + day - 1);
                }
                else if (day == 30)
                {
                    Aday = "rad" + 1;
                }
            }
            //July
            else if (month == 07)
            {
                if (day >= 01 & day <= 28)
                {
                    Aday = "rad" + (2 + day - 1);
                }
                else if (day >= 29 & day <= 31)
                {
                    Aday = "shw" + (day - 28);
                }
            }
            //August
            else if (month == 08)
            {
                if (day >= 01 & day <= 27)
                {
                    Aday = "shw" + (4 + day - 1);
                }
                else if (day >= 28 & day <= 31)
                {
                    Aday = "ziq" + (day - 27);
                }
            }
            //September
            else if (month == 09)
            {
                if (day >= 01 & day <= 26)
                {
                    Aday = "ziq" + (5 + day - 1);
                }
                else if (day >= 27 & day <= 30)
                {
                    Aday = "zih" + (day - 26);
                }
            }
            //October
            else if (month == 10)
            {
                if (day >= 01 & day <= 25)
                {
                    Aday = "zih" + (5 + day - 1);
                }
                else if (day >= 26 & day <= 31)
                {
                    Aday = "muh" + (day - 25);
                }
            }
            //November
            else if (month == 11)
            {
                if (day >= 01 & day <= 23)
                {
                    Aday = "muh" + (7 + day - 1);
                }
                else if (day >= 24 & day <= 30)
                {
                    Aday = "saf" + (day - 23);
                }
            }
            //December
            else if (month == 12)
            {
                if (day >= 01 & day <= 23)
                {
                    Aday = "saf" + (8 + day - 1);
                }
                else if (day >= 24 & day <= 31)
                {
                    Aday = "raa" + (day - 23);
                }
            }

            return Aday;
        }

        
    }
}
