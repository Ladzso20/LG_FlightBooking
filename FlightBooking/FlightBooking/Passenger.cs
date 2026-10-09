using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking
{
    public class Passenger
    {
        private string _name;
        private int _age;
        private int _bagcount;
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int BagCount { get { return _bagcount; } set { _bagcount = value; } }
        public Passenger(string name, int age)
        {
            _name = name;
            _age = age;
            _bagcount = 0;
        }
        public bool AddBag()
        {
            if(BagCount < 2)
            {
                BagCount += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsChild()
        {
            if(Age < 12)
            {
                return true;
            }
            return false;
        }
    }
}
