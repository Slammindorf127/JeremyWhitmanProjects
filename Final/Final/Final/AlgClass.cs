using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class AlgClass
    {
        public int vertex = 0;
        public int minDistance(int[] distance, bool[] addedTree)
            {
            int min = int.MaxValue;
            int minIndex = -1;

            for(int x = 0; x < vertex; x++)
            {
                if(distance[x] <= min && addedTree[x] == false)
                {
                    min = distance[x];
                    minIndex = x;
                }
            }
            return minIndex;
            }
         public void printArray(int[] distance, int a)
        {
            Console.Write("Output Data" + '\n');
            for(int x = 0; x < vertex; x++)
            {
                Console.Write(x + " \t\t " + distance[x] + "\n");
            }
        }
        public void algorithm(int[,] data, int source)
        {
            int[] distance = new int[vertex];

            bool[] addedTree = new bool[vertex];

            for(int x = 0; x < vertex; x++)
            {
                distance[x] = int.MaxValue;
                addedTree[x] = false;
            }

            distance[source] = 0;

            for(int x = 0; x < vertex - 1; x++)
            {
                int sourceDist = minDistance(distance, addedTree);
                addedTree[sourceDist] = true;

                for(int z = 0; z < vertex; z++)
                {
                    if(!addedTree[z] && data[sourceDist, z] != 0 && distance[sourceDist] != int.MaxValue && distance[sourceDist] + data[sourceDist, z] < distance[z])
                    {
                        distance[z] = distance[sourceDist] + data[sourceDist, z];
                    }
                }
            }
            printArray(distance, vertex);
        }
    }
}
