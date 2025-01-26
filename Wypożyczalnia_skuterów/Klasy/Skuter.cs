using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypożyczalnia_skuterów_i_motorów.Klasy
{
    public class Skuter : Motor
    {
        public bool IsElectric { get; set; }

        public Skuter(int engineCapacity, int productionYear, decimal rentalPricePerHour, bool isElectric, float lenx, float leny)
            : base(engineCapacity, productionYear, rentalPricePerHour, lenx, leny)
        {
            IsElectric = isElectric;
        }

        public override string ToString()
        {
            return base.ToString() + (IsElectric ? " Elektryczny" : " Benzynowy");
        }
    }
}