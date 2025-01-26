using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypożyczalnia_skuterów_i_motorów.Klasy
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Motor> RentedVehicles { get; private set; } // lista wypożycznonych przez użytkownika pojazdów

        public User(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            RentedVehicles = new List<Motor>();
        }

        public void RentVehicle(Motor vehicle)
        {
            RentedVehicles.Add(vehicle);
        }

        public override string ToString()
        {
            return $"User: {Name} ({Email})";
        }
    }
}