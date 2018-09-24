using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void UnitBuild()
        {
            Console.WriteLine("This is your new unit.");

            
            Platoon myplatoon = new Platoon();
            myplatoon.Company("A");

            
            Personnel myPersonnel = new Personnel();
            myPersonnel.PersonnelNumber();
            
            Vehicles myVehicles = new Vehicles();
            myVehicles.VehiclesNumber();

            Weapons myWeapons = new Weapons();
            myWeapons.WeaponsNumber();
        }
        static void Main()
        {
            try
            {
                UnitBuild();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
