using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        /// <summary>
        /// Given an array nums of distinct integers, return all the possible permutations.
        /// 
        /// Input: nums = [1,2,3]
        //  Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
        /// [[1,2,3],[1,2,3],]
        /// </summary>
        /// <param name="args"></param>
        private static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> input = new List<int>();
            input.Add(1);
            input.Add(2);
            input.Add(3);

            //List<int> output = 
            Permutations(input);
        }

        private static List<int> Permutations(List<int> list)
        {
            List<int> outputList = new List<int>();
            List<int> output = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                output.Add(list[i]);
                for (int j = i + 1; j < list.Count; j++)
                {
                    output.Add(list[j]);
                }

            }
            //Console.WriteLine(output);

            return outputList;
        }
    }
}
