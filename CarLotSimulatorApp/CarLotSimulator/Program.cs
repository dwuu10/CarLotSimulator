using System;

namespace CarLotSimulator
{
    class Program
    {
        public static void MakeEngineNoise(string sound)
        {
            Console.WriteLine(sound);
        }
        public static void MakeHonkNoise(string sound) 
        {
            Console.WriteLine(sound);
        }
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var car1 = new Car();
            car1.Year = 1990;
            car1.Make = "Honkers";
            car1.Model = "H8";
            car1.EngineNoise = "Brrrrrrr brrrrrrrrrrrrrr";
            car1.HonkNoise = "Honk Honk";
            car1.IsDriveable = true;

            var car2 = new Car();
            car2.Year = 2006;
            car2.Make = "BEP";
            car2.Model = "BE";
            car2.EngineNoise = "wheeeeeeee wheeeeeeeeeeeee";
            car2.HonkNoise = "Beep Beep";
            car2.IsDriveable = true;

            var car3 = new Car();
            car3.Year = 1979;
            car3.Make = "Vrromobile";
            car3.Model = "Zoomer";
            car3.EngineNoise = "Vroom Vroom";
            car3.HonkNoise = "Brrrrrrt Brrrrrrt";
            car3.IsDriveable = true;

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Console.WriteLine($"{car1.Year} {car1.Make} {car1.Model}:");
            MakeEngineNoise(car1.EngineNoise);
            MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine();
            Console.WriteLine($"{car2.Year} {car2.Make} {car2.Model}:");
            MakeEngineNoise(car2.EngineNoise);
            MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine();
            Console.WriteLine($"{car3.Year} {car3.Make} {car3.Model}:");
            MakeEngineNoise(car3.EngineNoise);
            MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
