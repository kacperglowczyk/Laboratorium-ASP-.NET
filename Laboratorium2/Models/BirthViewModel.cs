using System.Globalization;
using System.Data;
using System;

namespace Laboratorium2.Models
{
    public class BirthViewModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public bool IsValid()
        {
            return Name != null && BirthDate < DateTime.Today;
        }

        public int age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;

                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }

        }
    }
}