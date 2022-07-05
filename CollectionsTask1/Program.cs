using System;
using System.Collections.Generic;

namespace CollectionsTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> explanatoryDictionary = CreateDictionary();
            bool isRun = true;

            while (isRun)
            {
                Console.WriteLine("Введите слово для поиска его значения в ловаре, exit - для выхода из программы");
                string userInput = Console.ReadLine();

                OutputMeaningWord(explanatoryDictionary, userInput);
                isRun = userInput != "exit";
            }
        }

        static void OutputMeaningWord(Dictionary<string, string> explanatoryDictionary, string userInput)
        {
            if (explanatoryDictionary.ContainsKey(userInput) == false)
            {
                Console.WriteLine($"Я не знаю что значит слово {userInput}");
            }
            else
            {
                Console.WriteLine($"{userInput} - {explanatoryDictionary[userInput]}");
            }
        }

        static Dictionary<string, string> CreateDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "Дом" , "Жилое (или для учреждения) здание" },
                { "Река" , "Постоянный водный поток значительных размеров с естественным течением по руслу от истока до устья"},
                { "Страна" , "Территория, имеющая собственное государственное управление или управляемая другим государством"}
            };
            return dictionary;
        }
    }
}
