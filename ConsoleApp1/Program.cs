using System;
using Skole_Libary;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program program = new Program();
            PersonController controller = new PersonController();
            controller.AddData();
            program.Menu();
        }

        public void Menu()
        {
            Person person = new Person();
            Console.WriteLine("Welcome to School");
            Console.WriteLine(" _______________");
            Console.WriteLine("| 1. Print      |");
            Console.WriteLine("| 2. Add        |");
            Console.WriteLine("| 3. Delete     |");
            Console.WriteLine("| 4. Update     |");
            Console.WriteLine("|_______________|");
            string input = Convert.ToString(Console.ReadLine());
            switch (input)
            {
                case "1":
                    PrintData();
                    break;

                case "2":

                    break;
            }
        }

        public void PrintData()
        {
            Console.Clear();
            Console.WriteLine("Hvilken type liste vil du se?");
            string input = Convert.ToString(Console.ReadLine());
            switch (input)
            {
                case "Person":
                    foreach (Person person in PersonController.pl.Folk)
                    {
                        Console.WriteLine(person.Id);
                        Console.WriteLine(person.Navn);
                        Console.WriteLine(person.Cpr);
                        Console.WriteLine(person.Alder);
                        Console.WriteLine(person.Gender);
                    }
                    break;

                case "Elev":
                    foreach (Elev elev in PersonController.pl.Folk)
                    {
                        Console.WriteLine(elev.Id);
                        Console.WriteLine(elev.Hold);
                        Console.WriteLine(elev.Værge);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}