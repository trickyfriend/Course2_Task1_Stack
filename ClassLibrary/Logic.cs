using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public static class Logic
    {
        public static void ReadFile(string filename, MyStack stack)
        {
            using ( StreamReader sr = new StreamReader(filename) )
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    for (int i = 0; i < words.Length; i++) // могут быть граничные ошибки 
                    {
                        stack.Push(words[i]);
                    }
                }
            }
        }

        public static void WriteFile(string filename, MyStack stack)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                while (!stack.StackIsEmpty())
                {
                    sw.Write(stack.Pop() + " ");
                }
            }
        }
    }
}
