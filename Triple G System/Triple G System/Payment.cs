using System;
using System.Collections.Generic;
using System.Text;

namespace Triple_G_System
{
    class Payment
    {

        private string cardName;
        private string cardNumber;
        private string exMonth;
        private string exYear;
        private string cvcCode;

        public Payment()
        {

        }

        public Payment(string card_name, string card_number, string ex_month, string ex_year, string cvc_code)
        {
            cardName = card_name;
            cardNumber = card_number;
            exMonth = ex_month;
            exYear = ex_year;
            cvcCode = cvc_code;

        }

        public bool ValidName(string name)
        {
            if (name.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ValidCardNumber(string number)
        {
            if (number.Length == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidExMonth(string month)
        {
            if (month.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidExYear(string year)
        {
            if (year.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool ValidCvcCode(string code)
        {
            if (code.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
