using System;
using System.Collections.Generic;
using System.Linq;
using Wypożyczalnia_skuterów_i_motorów.Klasy;
using System.Windows;

namespace Wypożyczalnia_skuterów_i_motorów.Klasy
{
    public class Wypożyczenie
    {

        public Guid Id { get; private set; }
        private List<Motor> _vehicles;
        private List<OkresWypożyczenia> _okresyWypożyczenia; // Użyto private żeby dostęp był tylko w tej klasie 

        public Wypożyczenie()
        {
            Id = Guid.NewGuid();
            _vehicles = new List<Motor>();
            _okresyWypożyczenia = new List<OkresWypożyczenia>(); //Zachowuje wszytskie wypożyczenia jakie zostały zrobione kiedykolwiek
        }

        public void DodajPojazd(Motor vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public List<Motor> DostępnePojazdy(DateTime startDate, DateTime endDate)
        {
            return _vehicles.Where(vehicle => !_okresyWypożyczenia.Any(ow => ow.Vehicle == vehicle && ow.IsRented(new OkresWypożyczenia(startDate, endDate, vehicle)))).ToList();
        }

        public void WypożyczPojazd(User user, Motor vehicle, DateTime startDate, DateTime endDate)
        {
            var newPeriod = new OkresWypożyczenia(startDate, endDate, vehicle);
            if (_vehicles.Contains(vehicle) && !_okresyWypożyczenia.Any(ow => ow.IsRented(newPeriod)))
            {
                _okresyWypożyczenia.Add(newPeriod);
                user.RentVehicle(vehicle);
                MessageBox.Show($"{user.Name} wypożyczył {vehicle} od {startDate:yyyy-MM-dd} do {endDate:yyyy-MM-dd}");
            }
            else
            {
                MessageBox.Show("Pojazd niedostępny w tym okresie.");
            }
        }
    }
}