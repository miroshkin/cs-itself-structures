using System;
using System.Drawing;

namespace Cs.Itself.Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            uint sizeOfCollection = 100000000;

            PointClass[] points = new PointClass[sizeOfCollection];
            for (uint i = 0; i < sizeOfCollection; i++)
            {
                points[i] = new PointClass(i, i);
            }

            PrintAllocatedMemorySizeToConsole();

            PointStructure[] pointStructures = new PointStructure[sizeOfCollection];
            for (uint i = 0; i < sizeOfCollection; i++)
            {
                pointStructures[i] = new PointStructure(i, i);
            }

            PrintAllocatedMemorySizeToConsole();

        }

        private static void PrintAllocatedMemorySizeToConsole()
        {
            long memory = GC.GetTotalMemory(true);
            Console.WriteLine($"Allocated memory: {memory}");
        }
    }
}
