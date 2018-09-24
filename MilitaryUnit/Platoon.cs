using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Platoon
    {
        public void Company(string NameOfCompany)
        {
            Console.WriteLine($"Company name:{NameOfCompany}");
        }
        public void Personnel(string NumberOfPersonnel)
        {
            Console.WriteLine($"Personnel number:{NumberOfPersonnel}");
        }
        public void Vheicles(string NumberOfVheicles)
        {
            Console.WriteLine($"Vheicles number:{NumberOfVheicles}");
        }
        public void Weapons(string NumberOfWeapons)
        {
            Console.WriteLine($"Weapons number:{NumberOfWeapons}");
        }
    }

}
