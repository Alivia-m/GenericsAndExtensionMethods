using System;
using System.IO;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T".
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Equipment". The second class called "Food".
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO create some instances of type Food and Equipment and Add them the correct storage bins.

        //TODO In the program class Create a static void method called CountToNum that has a generic type called "T".
        //TODO Give the method a T paramter called "n".
        //TODO In the method scope make the method print all the numbers from 0 to "n".
        //TODO Call the method in the Main first by giving it a float number. Then call it again by giving it a double number.

        public static void CountToNum<T>(T[] n)
        {
            foreach(var number in n)
            {
                Console.WriteLine(number);
            }
        }


        static void Main(string[] args)
        {
            Storage<Equipment> equipStorage = new Storage<Equipment>();
            Storage<Food> foodStorage = new Storage<Food>();

            var apples = new Food();
            var crackers = new Food();
            var soccerBall = new Equipment();
            var golfClub = new Equipment();

            foodStorage.Bin.Add(apples);
            foodStorage.Bin.Add(crackers);
            equipStorage.Bin.Add(soccerBall);
            equipStorage.Bin.Add(golfClub);
          
            var numbersList1 = new int[] { 1, 2, 3, 4, 5, 6 };
            var numbersList2 = new double[] { 2.05, 10.3, 17.7, 4.44, 81.0, 6.2};
            var numbersList3 = new float[] { -1, -2, -3, -4, -5, -6 };

            CountToNum(numbersList2);
            Console.WriteLine("-----------------");
            CountToNum(numbersList3);

            Console.WriteLine("-----------------");
            var sorted = numbersList1.Sort();
            var odds = ExtensionMethods.Odds<int>(numbersList1);
            
        }
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create an extension method called "FindOdds" this method should take an IEnumerable of type integers and return a new IEnumerable of only the odd integers. Use linq in the scope to find odd numbers.

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
