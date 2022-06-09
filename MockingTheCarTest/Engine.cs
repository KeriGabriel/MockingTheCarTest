using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingTheCarTest
{
    public class Engine
    {
        private int _horsepower;
        private Enums.FuelType _fuel;
        private Enums.FuelAmount _amount;
        public Engine(int Horsepower, Enums.FuelType Fuel, Enums.FuelAmount Amount )
        {
            _horsepower = Horsepower;
            _fuel = Fuel;
            _amount = Amount;
        }
        public bool Start()
        {
            return _horsepower > 0 && _amount != Enums.FuelAmount.Empty;
        }
    }
}
