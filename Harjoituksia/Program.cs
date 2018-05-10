using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituksia
{
    
    class Program
    {
     
        static void Main(string[] args)
        {

            Dictionary<String, String> morseToText = new Dictionary<string, string>();

            morseToText.Add("A",".-");
            morseToText.Add("B","-...");
            morseToText.Add("C","-.-.");
            morseToText.Add("D","-..");
            morseToText.Add("E",".");
            morseToText.Add("F","..-");
            morseToText.Add("G","--.");
            morseToText.Add("H","....");
            morseToText.Add("I","..");
            morseToText.Add("J",".---");
            morseToText.Add("K","-.-");
            morseToText.Add("L",".-..");
            morseToText.Add("M","--");
            morseToText.Add("N","-.");
            morseToText.Add("O","---");
            morseToText.Add("P",".--.");
            morseToText.Add("Q","--.-");
            morseToText.Add("R",".-.");
            morseToText.Add("S","...");
            morseToText.Add("T","-");
            morseToText.Add("U","..-");
            morseToText.Add("V","...-");
            morseToText.Add("W",".--");
            morseToText.Add("X","-..-");
            morseToText.Add("Y","-.--");
            morseToText.Add("Z","--..");



            Console.WriteLine("Hello, Welcome to the Text to morse translator");
            
            Console.WriteLine("Please use capital letters");
            Console.WriteLine("Or type exit to quit the programn\n");

            while (true) {
                Console.WriteLine("Please type the text you want to translate to morse");

                string x = (Console.ReadLine());

                if (x == "exit")
                {
                    break;
                }

                if (morseToText.ContainsKey(x))
                {
                    Console.WriteLine(x + " is in morse " + morseToText[x],"\n");


                }
                else
                {
                    Console.WriteLine("Error invalid input\n");
                }

        }

        }
    }
}
/* 2 lists
 * if the user writes A
 * the programs will take the morse that is equal to A
 * Example
 * ABC
 * .- -... -.--
 */
