using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PassengerCodeApp
{
    internal class PassengerDatabase
    {
        private readonly string _filePath;
        private List<Passenger> _passengers;

        public PassengerDatabase(string filePath)
        {
            _filePath = filePath;
            LoadData();
        }

        public IReadOnlyList<Passenger> Passengers => _passengers;

        public void AddPassenger(Passenger passenger)
        {
            _passengers.Add(passenger);
            SaveData();
        }

        public void RemovePassenger(Passenger passenger)
        {
            _passengers.Remove(passenger);
            SaveData();
        }

        private void LoadData()
        {
            if (File.Exists(_filePath))
            {
                string jsonData = File.ReadAllText(_filePath);
                _passengers = JsonSerializer.Deserialize<List<Passenger>>(jsonData);
            }
            else
            {
                _passengers = new List<Passenger>();
            }
        }

        private void SaveData()
        {
            string jsonData = JsonSerializer.Serialize(_passengers, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonData);
        }
    }
}
