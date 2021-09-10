using System;

namespace MyApplication
{
    class Car
    {
        private string color;
        string model;

        public Car(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public string Color
        {
            get { return color;}   // get method
            set { color = value;}  // set method
        }

        public void printColor() 
        {
            Console.WriteLine(this.color);
        }

        public void printModel() 
        {
            Console.WriteLine(this.model);
        }
    }
}
