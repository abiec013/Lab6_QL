﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_QL
{
    class Program
    {
        static void Main(string[] args)
        {

            bool programContinues = true;
            while (programContinues == true)

            {

                Console.WriteLine("Welcome to Pig Latin Translator");
                Console.WriteLine("Please type a word");
                string str;
                str = Console.ReadLine();
                str = str.ToLower();
                //converts users text to lower case

                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                if (str.IndexOfAny(vowels) ==0)

                {
                    Console.WriteLine(str + "way");

                }

                else  

                {

                    Console.WriteLine(str.Substring(str.IndexOfAny(vowels)) + str.Substring(0, str.IndexOfAny(vowels)) + "ay");

                }

                

                string userChoice;
                Console.WriteLine("Would you like to translate another word?" + " " + "yes/No");
                userChoice = Console.ReadLine();

                if (userChoice == "yes")
                {
                    programContinues = true;
                }

                else if (userChoice == "no")
                {
                    programContinues = false;
                    Console.WriteLine("Bye");
                }

                else
                {
                    programContinues = false;
                }

            }
            
            
              
            

           

            



           
        }


    }
}