using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCodeApp
{
    internal class Passenger
    {
        private DateTime _birthday;

        public string Name { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public Meals Meals { get; set; }

        public TravelClass TravelClass { get; set; }

        public City Departure { get; set; }

        public City Destination { get; set; }

        public DateTime DepartingDate { get; set; }

        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        public int Age
        {
            get
            {
                var currentDate = DateTime.Now;
                var age = currentDate.Year - _birthday.Year;

                if (_birthday > currentDate.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }

        public static int CalculateAge(DateTime birthDate)
        {
            var currentDate = DateTime.Now;
            var age = currentDate.Year - birthDate.Year;

            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

    }
}
