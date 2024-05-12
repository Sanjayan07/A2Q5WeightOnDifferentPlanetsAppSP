/*Name: Sansayan Pratheepan
 * Date: 2/24/2024
 * Title: A2Q5 Weight On Different Plants Applications SP
 * Purpose: Ask for name and weight, then output their weight on various plants in the solar systems, using the G-force of the planet.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q5WeightOnDifferentPlanetsAppSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration

            string strName;
            string strWeight;

            double dblWeightOnMercury;
            double dblWeightOnVenus; //Stated all my variables here
            double dblWeightOnEarth;
            double dblWeightOnMars;
            double dblWeightOnJupiter;
            double dblWeightOnSaturn;
            double dblWeightOnUranus;
            double dblWeightOnNeptune;
            double dblWeightOnPluto;
            double dblWeight;
            //Input

            Console.WriteLine("What is your Name?");
            Console.Write("Name: ");
            strName = Console.ReadLine(); 
            Console.WriteLine("Please enter your weight (in Kilograms)"); //Asked for all the inputs, this one is the weight, and above is the Name
            Console.Write("Weight(kg): ");
            strWeight = Console.ReadLine();
            dblWeight = Double.Parse(strWeight);
           


            //Process
            dblWeightOnMercury = dblWeight * 0.38;
            dblWeightOnVenus = dblWeight * 0.91; //Calculating all the weights on different plants using G-Force of each planet
            dblWeightOnEarth = dblWeight * 1.0;
            dblWeightOnMars = dblWeight * 0.38;
            dblWeightOnJupiter = dblWeight * 2.6;
            dblWeightOnSaturn = dblWeight * 1.1;
            dblWeightOnUranus = dblWeight * 0.90;
            dblWeightOnNeptune = dblWeight * 1.1;
            dblWeightOnPluto = dblWeight * 0.07;




            //Output

            Console.WriteLine(strName + " Your Weight On....");

            Console.WriteLine("Mercury is: " + (Math.Round(dblWeightOnMercury, 2)) + " Kg" ); //Output the Weight, on each planet, aswell as round to 2 decimal place
            Console.WriteLine(("Venus is: " + Math.Round(dblWeightOnVenus, 2)) + " Kg");
            Console.WriteLine("Earth is: " + (Math.Round(dblWeightOnEarth, 2)) + " Kg");
            Console.WriteLine("Mars is: " + Math.Round(dblWeightOnMars, 2) + " Kg");
            Console.WriteLine("Jupiter is: " + Math.Round(dblWeightOnJupiter, 2) + " Kg");
            Console.WriteLine("Saturn is: " + (Math.Round(dblWeightOnSaturn, 2)) + " Kg");
            Console.WriteLine("Uranus is: " + (Math.Round(dblWeightOnUranus, 2)) + " Kg");
            Console.WriteLine("Neptune is: " + Math.Round(dblWeightOnNeptune, 2) + " Kg");
            Console.WriteLine("Pluto is: " + (Math.Round(dblWeightOnPluto, 2)) + " Kg");


            Console.ReadKey();
        }
    }
}
