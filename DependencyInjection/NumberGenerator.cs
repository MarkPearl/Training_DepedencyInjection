using System;

namespace DependencyInjection
{
    public class NumberGenerator : INumberGenerator
    {
        private readonly Random _random;

        public NumberGenerator()
        {
            _random = new Random(100);
        }
        public int Generate()
        {
            return _random.Next(100);
        }
    }
}