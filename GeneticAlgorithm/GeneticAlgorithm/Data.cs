using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public static class Data
    {
        public static List<int> Set { get; set; }
        public static int Value { get; set; }
        public static void Init(List<int> set,int value)
        {
            Set = set;
            Value = value;
            Set.Sort();
        }
    }
}
