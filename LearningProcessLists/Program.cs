using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningProcessLists
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// Declaring and initialising Lists.
        /// </summary>

        static void Main(string[] args)
        {
            List<int> values = new List<int> {
                1234,
                763,
                4920,
                32000,
                2007,
                555,
                5893,
                67
            };

            List<int> values2 = new List<int>();
            values2.Add(1234);
            values2.Add(763);
            values2.Add(4920);
            values2.Add(2007);
            values2.Add(555);

            //SortAndPrintByValue(values);
            SortAndPrintByDigit(values2);
        }

        /// <summary>
        /// Sorts the list and prints by value.
        /// Bubblesort used.
        /// </summary>

        public static void SortAndPrintByValue(List <int> values)
        {
            for (int i = 1; i < values.Count(); i++)
            {
                for (int j = 0; j < (values.Count() - i); j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }

            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Sorts the list by the first digit of a number and print it out.
        /// Bubblesort used.
        /// </summary>

        public static void SortAndPrintByDigit(List <int> values2)
        {
            for (int i = 1; i < values2.Count(); i++)
            {
                for (int j = 0; j < (values2.Count() - i); j++)
                {
                    char[] charWert1 = values2[j].ToString().ToCharArray();
                    int compareValue1 = charWert1[0];

                    char[] charWert2 = values2[j + 1].ToString().ToCharArray();
                    int compareValue2 = charWert2[0];

                    if (compareValue1 > compareValue2)
                    {
                        int temp = values2[j];
                        values2[j] = values2[j + 1];
                        values2[j + 1] = temp;
                    }
                }
            }

            foreach (int i in values2)
            {
                Console.WriteLine(i);
            }
        }
    }
}