﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {   //Create a seperate class file called Car
        //Done



        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable 
        //DONE
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }



        public Car(int year, string make, string model, string enginenoise, string honknoise, bool isdrivable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDrivable = isdrivable;

        }

        public Car()
        {

        }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }


        //TODO

        //Create a seperate class file called Car                                                                           X
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable                   X
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()                                          X
        //The methods should take one string parameter: the respective noise property                                       X


        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        
    }
}
