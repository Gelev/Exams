using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] output = input;
        int sum = 0;

        while (output.Length > 0)
        {
            int index = int.Parse(Console.ReadLine());
            int elementToRemove = 0;
            
            if (index >= 0 && index < output.Length)
            {
                elementToRemove = output[index];
                sum += elementToRemove;
                output = output.Where((source, ind) => ind != index).ToArray();
            }
            if (index < 0)
            {
                index = 0;
                elementToRemove = output[index];
                sum += elementToRemove;
                output[index] = output[output.Length - 1];
            }
            if (index > output.Length)
            {
                index = output.Length - 1;
                elementToRemove = output[index];
                sum += elementToRemove;
                output[index] = output[0];
            }

            
            //updating the remaining values of the array
            for (int j = 0; j < output.Length; j++)
            {
                
                if (output[j] <= elementToRemove)
                {
                    output[j] += elementToRemove;
                }
                else
                {
                    output[j] -= elementToRemove;
                }
            }
        }
        Console.WriteLine(sum);
   }
}


