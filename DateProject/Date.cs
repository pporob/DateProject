using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateProject
{
    public class Date
    {
        public int day, month, year;


        public Date(int day, int month, int year)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }




        public bool isLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else return false;
        }

        public string getMonthName()
        {
            string[] MonthName = { "Sijecanj", "Veljaca", "Ozujak", "Travanj", "Svibanj", "Lipanj", "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac" };
            return MonthName[month - 1];
        }

        public int getNumberOfRemaingDaysInMonth()
        {
            if ((month % 2 == 1 && month <= 7) || (month % 2 == 0 && month >= 8))
            {
                return 31 - day;
            }
            else if (month == 2)
            {
                if (isLeapYear())
                    return 29 - day;
                else
                    return 28 - day;
            }
            else
                return 30 - day;
        }
    }

}





