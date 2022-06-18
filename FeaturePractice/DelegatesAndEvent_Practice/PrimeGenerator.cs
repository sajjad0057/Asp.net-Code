using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent_Practice
{
    public class PrimeGenerator
    {

        public delegate void Message(List<int> primes);

        public event Message PrimeGenerationComplete;

        private List<int> _primes;
        public void Generate(int range)
        {
            _primes = new List<int>();

            for (int i = 0; i < range; i++)
            {
                if (_IsPrime(i))
                {
                    _primes.Add(i);
                }
            }

            PrimeGenerationComplete.Invoke(_primes);
        }

        //public List<int> GetPrimes()
        //{
        //    return _primes;
        //}


        private bool _IsPrime(int num)
        {
            for(int i = 0; i < Math.Sqrt(num); i++)
            {
                if (num % 2 == 0)
                    return false;
            }
            return true;
        }
    }
}
