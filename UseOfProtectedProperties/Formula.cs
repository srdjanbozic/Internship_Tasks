using System;
using System.Collections.Generic;
using System.Text;

namespace UseOfProtectedProperties
{
    class Formula : Vehicle
    {
        public double Acceloration { get; set; }
       

        public Formula(double acceloration,string brand, string model, double topSpeed, double conversionFactor)
            : base(brand,model,topSpeed, conversionFactor)
        {
            this.Acceloration = acceloration;
            
        }

        protected override double TopSpeed()
        {
            return topSpeed;
        }

        protected override double ConversionMPHToKmh()
        {
            return conversionFactor * topSpeed;
        }

        public override void ReadSpeed()
        {
            Console.WriteLine("Formula 1 brand : " + brand + "\n \n " +
                              "Model of formula: " + model + "\n \n" +
                              "Can accelorate from 0-60mph in roughly : " + Acceloration + " seconds" +  "\n \n" +
                              "And can reach top speed of : " + topSpeed + "mph " + "\n \n" +
                              "Or converted to km per hour: " + ConversionMPHToKmh() + " km/h")  ;
        }


    }
}
