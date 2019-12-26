using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        public class InsertionSorter
        {
            public int[] list;
            public void Sort()
            {
                for(int i = 1;i < list.Length; i++)
                {
                    int t = list[i];
                    int j = i;
                    while ((j > 0) && (list[j - 1] > t))
                    {
                        list[j] = list[j - 1];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
