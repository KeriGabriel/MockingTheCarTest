using System;

namespace MockingTheCarTest
{
    public class Vehicle
    {
        private Engine _engine;

        public Vehicle(Engine E)
        {
            _engine = E;
        }
        public bool Start()
        {
            if (_engine == null)
                return false;

            return _engine.Start();
        }
    }
}
