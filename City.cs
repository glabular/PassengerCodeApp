using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCodeApp
{
    internal class City
    {
        private static readonly List<string> EUcities = new List<string>
        {
            "Paris",
            "Berlin",
            "Rome",
            "Madrid",
            "Amsterdam",
            "Brussels",
            "Vienna",
            "Stockholm",
            "Lisbon",
            "Prague"
        };
        private static readonly List<string> UKcities = new List<string>
        {
            "London",
            "Manchester",
            "Birmingham",
            "Glasgow",
            "Liverpool",
            "Edinburgh",
            "Bristol",
            "Leeds",
            "Sheffield",
            "Newcastle"
        };
        private static readonly List<string> AsianCities = new List<string>
        {
            "Tokyo",
            "Seoul",
            "Shanghai",
            "Mumbai",
            "Bangkok",
            "Beijing",
            "Delhi",
        };
        private static readonly List<string> AmericanCities = new List<string>
        {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Miami",
            "Toronto",
            "Mexico City",
            "Buenos Aires",
            "Vancouver"
        };

        public City(string name)
        {
            Name = name;
            DestinationCode = GetDestinationCode();
        }

        public string Name { get; private set; }

        public DestinationCode DestinationCode { get; private set; }

        private DestinationCode GetDestinationCode()
        {
            if (EUcities.Contains(Name))
            {
                return DestinationCode.Europe;
            }

            if (UKcities.Contains(Name))
            {
                return DestinationCode.UK;
            }

            if (AsianCities.Contains(Name))
            {
                return DestinationCode.Asian;
            }

            if (AmericanCities.Contains(Name))
            {
                return DestinationCode.Asian;
            }

            return DestinationCode.Unknown;

        }

        public ObservableCollection<string> GetMatchedCities(string pattern)
        {
            // TODO: Dinamically populate listbox with matched cities.
            var mathchedCities = new ObservableCollection<string>();




            return mathchedCities;
        }
    }
}
