﻿using System;
using System.Collections.Generic;
using DinerMax3000.BusinessLayer;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = menusFromDatabase[0];
            //firstMenu.SaveNewMenuItem("Smorgas", "A classic nordic dish.", 10);
            menusFromDatabase = Menu.GetAllMenus();

            Order hungryGuestOrder = new Order();

            foreach (Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in currentMenu.items)
                {
                    hungryGuestOrder.items.Add(currentItem);
                }
            }

            Console.WriteLine("The total is:" + hungryGuestOrder.Total);




            Console.ReadKey();


        }
    }
}
