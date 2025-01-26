using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypożyczalnia_skuterów_i_motorów.Klasy
{
    public class OkresWypożyczenia
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Motor Vehicle { get; set; }

        public OkresWypożyczenia(DateTime startDate, DateTime endDate, Motor vehicle)
        {
            StartDate = startDate;
            EndDate = endDate;
            Vehicle = vehicle;
        }

        public bool IsRented(OkresWypożyczenia other)
        {
            return Vehicle == other.Vehicle && StartDate < other.EndDate && EndDate > other.StartDate; //Sprawdzamy czy ten sam pojazd nie został już wynajęty w danym czasie
        }

        public override string ToString()
        {
            return $"{Vehicle} wynajęty od {StartDate:yyyy-MM-dd} do {EndDate:yyyy-MM-dd}";
        }
    }
}