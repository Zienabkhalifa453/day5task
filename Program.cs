using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp2
{
    class program
    {
       
       
        static void Main(string[] args)
        {
            string filename = "data.txt";
            FileStream F = new FileStream(filename, FileMode.Open);
            StreamReader N = new StreamReader(F);
            string content =N.ReadToEnd();
            string s= "";
            String[] words = content.Split(' ');
            int max = 0;
            foreach (var word in words)
            {
                if (word.Length >= max)
                    s = word;
                max = word.Length;
            }

           F.Close();
            N.Close();
            Console.WriteLine("The longest word  is {0} \n ", s);
            Console.WriteLine("The length of the word  is {0} \n ", s.Length);







        }



    }
}