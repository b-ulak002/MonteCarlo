using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarlo
{
    class TestCoordinate
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                Coordinate[] arrayOfCordinate = new Coordinate[arrayLength];
                Random random = new Random();
                int counter = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    arrayOfCordinate[i] = new Coordinate(random);

                    if (arrayOfCordinate[i].Hypotenuse() <= 1)
                    {
                        counter++;
                    }
                }
                double avg = (counter / (double)arrayOfCordinate.Length) * 4;
                Console.WriteLine($"Total # of points overlapping the circle = {counter}");
                Console.WriteLine($"generated pi = {avg}, real pi = {Math.PI}, difference = {Math.Abs(Math.PI - avg)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
