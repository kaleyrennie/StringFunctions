using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Kaley";
            //string quote = "The man said, \\Hello\", Kaley. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("a");
            //bool trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Kaley";
            //name = "Cala";

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Kaley.");


            //Console.WriteLine(sb);
            //Console.ReadLine();


            string name = "Hello, my name is Kaley. ";
            string pet = "I have one dog. ";
            string breed = "He is a french bulldog. ";

            pet = pet.ToUpper();
            Console.WriteLine(name + pet + breed);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("In Criminal Minds Season 15 Episode 6 Dr. Spencer Reed had to deal with his past. ");
            sb.Append("While figuring out a new relationship, he was forced to face someone he thought he was finished with.");
            sb.Append("Cat Adams, a previous unsub they locked away now has a partner  working on the outside. ");
            sb.Append("In order to save his new love interest Maxine, he must do the unthinkable - go on a date with the women who almost killed him. ");
            sb.Append("This episode was one of the better ones this season. ");
            sb.Append("I would urge you to watch all 15 seasons.");
            sb.Append("It seems like a lot, but it is worth it. ");

            Console.WriteLine(sb);



                

        }
    }
}
