using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Car
    {
        int carno;
        string carName;
        string carType;
        readonly double carcost = 1700000;

        public Car(int carno, string carName, string carType)
        {
            this.carno = carno;
            this.carName = carName;
            this.carType = carType;
            //this.carcost = carcost;

            Console.WriteLine($" carno is : {carno}, car namee is :{carName}, car Type is: {carType}, car cost is :{carcost}");
        }

        public Car(double cost)
        {
            carcost = cost;
            Console.WriteLine("After  The changing are");
            Console.WriteLine($" carno is : {carno}, car namee is: {carName}, car Type is: {carType}, car cost is: {carcost}");
        }
        public void displaycardetails()
        {
            Console.WriteLine("Before  The changing are");
            Console.WriteLine($" carno is : {carno}, car namee is: {carName}, car Type is: {carType}, car cost is: {carcost}");

        }
    }
}
