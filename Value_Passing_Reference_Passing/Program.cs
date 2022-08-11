using System;

namespace Value_Passing_Reference_Passing
{
    class Program
    {
        public class Car
        {
            public string CarBrand { get; set; }
            public string CarModel { get; set; }
        }

        public static void ChangeReference (Car car1)
        {
            car1.CarBrand = "audi";
            car1.CarModel = "a3";
            Console.WriteLine("Value while in the method: " + car1.CarBrand + " " + car1.CarModel);
        }

        public static void ChangeValue(int value)
        {
            value = value * 10;
            Console.WriteLine("Value while in the method: " + value);
        }

        static void Main(string[] args)
        {
            //Value type
            ////////////////////////////////////////////////////////////////////////////
            ///

            int value = 10;
            //Value before passing it to the ChangeValue method  

            Console.Write("Value before passing the value to the method: {0} \n", value);

            ChangeValue(value);

            //Value after passing it to the ChangeValue method

            Console.Write("Value after passing the value to the method: {0} \n\n ", value);



            //Reference type
            //////////////////////////////////////////////////////////////////////////////
            ///

            Car car1 = new Car();
            car1.CarBrand = "bmw";
            car1.CarModel = "320d";

            //Value before passing it to the ChangeReference method
            Console.Write("Value before passing it to the method: {0} {1} \n ", car1.CarModel, car1.CarBrand);

            ChangeReference(car1);

            //Value after passing it to the ChangeReference method

            Console.Write("Value after passing it to the method: {0} {1} \n ", car1.CarBrand, car1.CarModel);



        }


       
    }
}
