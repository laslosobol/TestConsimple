using System;
using System.ComponentModel.Design;
using System.Text.Json;
using TestConsimple.Logic;
using System.Linq;

namespace TestConsimple.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = Deserializer.Deserialize(JsonReader.Connection("https://tester.consimple.pro/"));
            System.Console.WriteLine("Product Name      Category Name");
            foreach (var product in root.Products)
            {
                System.Console.WriteLine
                    ($"{product.Name}       {root.Categories.Where(_ => _.Id == product.CategoryId).Select(_ => _.Name).FirstOrDefault()}");
            }
        }
    }
}