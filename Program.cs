using System;
using exercicio.Entities;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i ++){
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (type){
                    case 'c':
                        Product prod = new Product(name, price);
                    break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        
                    break;
                }
            }
        }
    }
}
