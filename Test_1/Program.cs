using System;
using System.Linq;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testCaseCount = int.Parse(Console.ReadLine());
            
            for (var i = 0; i < testCaseCount; i++)
            {
                var testNumberOfTasks = int.Parse(Console.ReadLine());
                var tasks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int[] tempTasks = new int[testNumberOfTasks];
                Array.Copy(tasks, tempTasks, testNumberOfTasks);
                Array.Sort(tempTasks);
                int nice = 1;
                int max = tasks.Max();
                int[] priorityArray = new int[testNumberOfTasks];
                while (Array.FindIndex(priorityArray, x => x == 0) != -1)
                {
                    for (int j = 0; j < tasks.Length; j++)
                    {
                        if (tasks[j] == max | tasks[j] == max - 1)
                        {
                            priorityArray[j] = nice;

                        }
                    }
                    nice++;
                    max = Array.FindLast(tempTasks, y => y < max - 1);

                }
                for (int k = 0; k < priorityArray.Length; k++)
                {
                    Console.Write(priorityArray[k]+" ");
                }

                Console.WriteLine();
                
                
            }
        }
    }
}
