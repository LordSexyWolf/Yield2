using System;
using System.Collections.Generic;


namespace Yield2 {
    class Program
    {

        static List<string> pple = new List<string>();

        public static void Main(string[] args)
        {

            pple.Add("Salinas");
            pple.Add("Salgado");
            pple.Add("Salas");
            pple.Add("Hernández");
            pple.Add("Harrison");
            pple.Add("Hill");
            pple.Add("Henry");
            pple.Add("Hugs");

            foreach (string person in Filter())
            {
                Console.WriteLine(person);
            }
        }
        public static IEnumerable<string> Filter()
        {
            foreach(var person in pple)
            {
                if (person.StartsWith("H"))
                {
                    yield return person;
                }
            }
        }
    }
}