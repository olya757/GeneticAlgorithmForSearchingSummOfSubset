using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public delegate void ChangeTextBoxAndLabel(string tbText, string lbText);

    public static class Algorithm
    {
        public static event ChangeTextBoxAndLabel Change;

        public static List<int> Genes { get; set; }

        public static int Value { get; set; }


        public static bool nextState()
        {
            int j = Genes.Count() - 2;
            while (j != -1 && Genes[j] >= Genes[j + 1]) j--;
            if (j == -1)
                return false; // a - last permutation
            int k = Genes.Count() - 1;
            while (Genes[j] >= Genes[k]) k--;

            int tmp = Genes[j];
            Genes[j] = Genes[k];
            Genes[k] = tmp;

            // reverse back [j+1, n-1]
            int l = j + 1, r = Genes.Count() - 1;
            while (l < r)
            {
                tmp = Genes[l];
                Genes[l] = Genes[r];
                Genes[r] = tmp;
                l++;
                r--;
            }
            return true;
        }

        public static int CheckForCurrentSize(int size)
        {
            int summ = 0;
            for(int i = 0; i < size; i++)
            {
                summ += Genes[i];
            }
            return Math.Abs(Value-summ);
        }

        private static List<int> SubSet(int size)
        {
            List<int> res = new List<int>();
            for(int i = 0; i < size; i++)
            {
                res.Add(Genes[i]);
            }
            return res;
        }

        public static TimeSpan TimeOfMethod { get; set; }

        public static void FindResult()
        {
            DateTime start = System.DateTime.Now;
            List<int> bestResult = new List<int>();
            int minDif = -1;
            int minSize = Genes.Count();
            do
            {
                for (int size = 1; size <= Genes.Count(); size++)
                {
                    int tmp = CheckForCurrentSize(size);
                    if (minDif==-1 || tmp < minDif || ((tmp==minDif)&&(size<minSize)))
                    {
                        minDif = tmp;
                        bestResult = SubSet(size);
                        minSize = size;
                    }
                }
            }
            while (nextState());
            resofmethod= bestResult;
            TimeOfMethod = System.DateTime.Now - start;
            Change(ToString(resofmethod), TimeOfMethod.Ticks.ToString());
            Form1.Ready++;
        }

        public static string ToString(List<int> vs)
        {
            string res = "";
            int summ = 0;
            foreach (var g in vs)
            {
                res += g.ToString() + ' ';
                summ += g;
            }
            res += "Sum: " + summ.ToString();
            return res;
        }

        public static List<int> resofmethod { get; set; }

        private static Thread thread;

        public static void Result(List<int> genes, int value)
        {
            thread = new Thread(FindResult);
            Value = value;
            Genes = new List<int>();
            foreach(var g in genes)
            {
                Genes.Add(g);
            }
            Genes.Sort();
            thread.Start();
        }

    }
}
