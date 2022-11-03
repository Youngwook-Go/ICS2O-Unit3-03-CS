// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets volume of pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        //this function accept user input
        double sphereRadius;
        double sphereVolume;

        Console.WriteLine("This program gets volume of sphere.");
        Console.WriteLine("Please enter the value of the sphere.\n");
        Console.Write("Enter value of sphere radius : "); sphereRadius = Convert.ToInt32(Console.ReadLine());

        sphereVolume = Math.PI * Math.Pow(sphereRadius, 3) * 4 / 3;

        // this function prints the result
        Console.WriteLine("\nVolume of the sphere is : " + sphereVolume.ToString("0.00") + " cm³ ");
        Console.WriteLine("\ndone.");
    }
}