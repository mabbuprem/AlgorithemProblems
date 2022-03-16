using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("algorithm problems");

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.UserInput<string>();

            WordList wordList = new WordList();
            wordList.UserInput<string>();
        }
    }
}
