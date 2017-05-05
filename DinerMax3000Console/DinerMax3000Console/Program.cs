using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Taco", "All Norwegians eat taco on Friday", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask Dr.Jones";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba Lible", "A classic", 10);
            outsideDrinks.AddMenuItem("ScrewDriver", "Makes you hammered", 15);
            outsideDrinks.AddMenuItem("White Russian", "Really srong, not for Begginers", 18);
            outsideDrinks.AddMenuItem("A breath of spring", "Fresh Drink with bitter", 15);

            Order hungryGuestOrder = new Order();

            for (int x=0;x<=summerMenu.items.Count-1;x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach(MenuItem currentitem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentitem);
            }

            Console.WriteLine("The Total is: " + hungryGuestOrder.Total);
            try
            {
                outsideDrinks.AddMenuItem("Starter", "Small apperitive for customers which are waiting for dinner", 0);
            }
            catch (Exception throwException)
            {
                Console.WriteLine(throwException.Message);
            }

            Console.ReadKey();
            
        }
    }
}
