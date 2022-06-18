using System;
using System.Collections.Generic;

namespace Task_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<User> listuser = new List<User>
            {
                new User() { Name = "Igor", Login = 2345, IsPremium = true  },

                new User() { Name = "Roman", Login = 2342, IsPremium = false  },

                new User() { Name = "Natasha", Login = 6798, IsPremium = true}
            };

            foreach (var item in listuser)
            {
                if (item.IsPremium == false)
                {
                    User.ShowAds();
                }
                else Console.WriteLine($"Hello {item.Name}");
            }

           
        }
    }
}
