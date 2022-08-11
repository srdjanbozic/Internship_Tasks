using System;
using System.Collections.Generic;
using System.Text;

namespace UseOfProtectedProperties
{
    abstract class Vehicle
    {
        protected string brand;
        protected string model;
        protected double topSpeed;
        protected double conversionFactor;
       

        public Vehicle(string brand, string model, double topSpeed, double conversionFactor)
        {
            this.brand = brand;
            this.model = model;
            this.topSpeed = topSpeed;
            this.conversionFactor = conversionFactor;
            
        }

        protected abstract double ConversionMPHToKmh();
        protected abstract double TopSpeed();
        public abstract void ReadSpeed();

    }
}
