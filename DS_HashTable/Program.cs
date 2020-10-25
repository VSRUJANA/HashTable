using System;

namespace DS_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable Program!");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(1);
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                hash.Add(i, words[i]);
            }
            hash.GetFrequency("paranoid");

        }
    }
}
