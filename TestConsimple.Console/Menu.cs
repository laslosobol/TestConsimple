using System;
using System.Linq;
using TestConsimple.Logic;

namespace TestConsimple.Console
{
    public static class Menu
    {
        public static void Start()
        {
            var menu = 0;
            System.Console.Write("Choose action:\n1.Send Request\n2.Exit");
            menu = Convert.ToInt32(System.Console.ReadLine());
            if (menu == 1)
            {
                var root = Deserializer.Deserialize(JsonReader.Connection("https://tester.consimple.pro/"));
                    
                System.Console.WriteLine("Product Name      Category Name");
                foreach (var product in root.Products)
                {
                    System.Console.WriteLine
                        ($"{product.Name}       {root.Categories.Where(_ => _.Id == product.CategoryId).Select(_ => _.Name).FirstOrDefault()}");
                }
                Start();
            }
        }
    }
}