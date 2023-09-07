using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo01();
            Console.WriteLine();
            Demo02();
            Console.WriteLine();
            Demo03();
            Console.WriteLine();
            Console.ReadKey();
        }
        private static void Demo01()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver02 objDriver = new Driver02();

            objDriver.DriveObject(objCar);
            objDriver.DriveObject(objScooter);


        }
        private static void Demo02()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver01 objDriver = new Driver01();

            objDriver.DriveTypedObject(objCar);
            objDriver.DriveTypedObject(objScooter);

        }
        private static void Demo03()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver03 objDriver = new Driver03();
            Bus objBus = new Bus();

            objDriver.Driveobject(objCar);// pass the object
            objDriver.Driveobject(objScooter);
            objDriver.Driveobject(objBus);


        }
    }
}
