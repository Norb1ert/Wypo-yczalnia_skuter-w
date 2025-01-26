using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypożyczalnia_skuterów_i_motorów.Klasy
{
    public class Motor
    {
        public Guid Id { get; private set; }
        public float EngineCapacity { get; set; }
        public int ProductionYear { get; set; }
        public decimal RentalPricePerHour { get; set; }

        public float Lenx { get; set; }

        public float Leny { get; set; }


        public Motor(int engineCapacity, int productionYear, decimal rentalPricePerHour, float lenx, float leny)
        {
            Id = Guid.NewGuid();
            EngineCapacity = engineCapacity;
            ProductionYear = productionYear;
            RentalPricePerHour = rentalPricePerHour;
            Lenx = lenx;
            Leny = leny;

        }

        public override string ToString()
        {
            return $" ({EngineCapacity} dm^3) {RentalPricePerHour} ZŁ/Godzinę";
        }
    }
}