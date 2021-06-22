using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cat_House
{
    partial class Cat
    {

        public void Eat()
        {
            if (Energy == 0)
            {
                Console.WriteLine("Energy is 0 go to sleep. Cat can't eat something with 0 Energy.");
                return;
            }
            IncrementPrice(ref _price);
            IncrementMealQuantity(ref _mealQuantityOfCatToday);
            const int eatingEnergy = 20;
            if (Energy + eatingEnergy <= 100)
                Energy += eatingEnergy;
        }
        public void Play()
        {
            const int playEnergy = 10;
            if (Energy - playEnergy >= 0)
            {
                Energy -= playEnergy;
                Show();
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Energy is 0 go to sleep. Cat can't play with 0 Energy.");
                Show();
                Sleep();
                Thread.Sleep(500);
                Console.Clear();
            }
        }
        public void Sleep()
        {
            const int sleepEnergy = 20;
            if (Energy + sleepEnergy <= 100)
                Console.WriteLine($"{Energy += sleepEnergy}");
            IncrementPrice(ref _price);
            Show();
            Thread.Sleep(800);
        }
        static public void IncrementPrice(ref int price) => price += (price * 10) / 100;
        static public void IncrementMealQuantity(ref int mealQuantity) => mealQuantity += (mealQuantity * 85) / 100;
        public void Show()
        {
            if (Energy == 0)
            {
                Sleep();
                Console.Clear();
            }
            string trimVersionOfGender = Gender.Trim();
            StringBuilder gender = new StringBuilder();
            gender.Append(char.ToUpper(trimVersionOfGender[0]))
                  .Append(trimVersionOfGender.Substring(1));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Nick Name of Cat: {NickName}");
            Console.WriteLine($"Age of Cat : {Age} years old");
            Console.WriteLine($"Meal Quantitiy of Cat: {MealQuantity} gr");
            Console.WriteLine($"Price of Cat : {Price} $");
            Console.WriteLine($"Gender of Cat : {gender}");
            Console.WriteLine($"Energy of Cat : {Energy}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Meal Quantity of Cat for Today: {_mealQuantityOfCatToday} gr");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.ResetColor();
        }


    }
}
