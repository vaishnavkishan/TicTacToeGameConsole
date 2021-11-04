using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program2
    {

        /// <summary>
//        Evaluate the value of an arithmetic expression in Reverse Polish Notation.

        //Valid operators are +, -, *, and /. Each operand may be an integer or another expression.

        //Input: tokens = ["2","1","+","3","*"]
//        Output: 9
        /// </summary>
        /// <param name="args"></param>
        private static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> input = new List<string>();
            input.Add("2");
            input.Add("1");
            input.Add("+");
            input.Add("3");
            input.Add("*");

            //List<int> output = 
            PolishNotation(input);
        }

        private static void PolishNotation(List<string> list)
        {
            Stack<int> outputList = new Stack<int>();
            //List<int> output = new List<int>();

            //TODO: Validation

            foreach (string item in list)
            {
                if(item == "+")//TODO pass valid operators
                {
                    int first=outputList.Pop();
                    int second= outputList.Pop();

                    outputList.Push(first + second);
                }
                else if(item == "*")
                {
                    int first = outputList.Pop();
                    int second = outputList.Pop();

                    outputList.Push(first * second);
                }
                else
                {
                    outputList.Push(Convert.ToInt32(item));
                }
            }
            Console.WriteLine(outputList.Peek());

            //return outputList;
        }
    }
}
