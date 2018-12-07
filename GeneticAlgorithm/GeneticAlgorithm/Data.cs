using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public static class Data
    {
        private static List<int> Genes { get; set; }
        public static int Value { get; set; }
        public static List<KeyValuePair<int,Chromosome>> Chromosomes { get; private set; }
        public static int StartAmount { get; set; }

        public static bool FindResult { get; set; }
        public static void Init(List<int> genes,int value, int startAmount)
        {
            Genes = genes;
            Value = value;
            Chromosomes = new List<KeyValuePair<int, Chromosome>>();
            StartAmount = startAmount;
            FindResult = false;
            Genes.Sort();
            CreateFirstGeneration();
            Chromosomes.Sort((p1, p2) =>
            {
                if (p1.Key > p2.Key) return 1;
                if (p1.Key < p2.Key) return -1;
                return 0;
            });
            
        }
        public static void CreateFirstGeneration()
        {
            for(int i = 0; i < StartAmount; i++)
            {
                Chromosome chromosome = new Chromosome(Genes);
                Chromosomes.Add(new KeyValuePair<int, Chromosome>(chromosome.Fitness(),chromosome));
            }
            ChooseGoodChromosomes();
        }

        public static void ChooseGoodChromosomes()
        {
            Chromosomes.Sort((p1, p2) =>
            {
                if (p1.Key > p2.Key) return 1;
                if (p1.Key < p2.Key) return -1;
                return 0;
            });
            if (Chromosomes.First().Key == 0)
            {
                FindResult = true;
                return;
            }
            int finish = (int)(0.5 * Chromosomes.Count());
            List<KeyValuePair<int, Chromosome>> tmp = new List<KeyValuePair<int, Chromosome>>();
            foreach(var ch in Chromosomes)
            {
                tmp.Add(ch);
                finish--;
                if (finish < 0) break;
            }
            Chromosomes = tmp;
        }
        
        public static void MergeChromosomes()
        {
            List<KeyValuePair<int, Chromosome>> nextGeneration = new List<KeyValuePair<int, Chromosome>>();
            for (int i=0;i<Chromosomes.Count();)
            {
                var Parent1 = Chromosomes[i];
                i++;
                nextGeneration.Add(Parent1);
                if (i<Chromosomes.Count())
                {
                    var Parent2 = Chromosomes[i];
                    i++;
                    nextGeneration.Add(Parent2);
                    Chromosome child = Parent1.Value.RandomCrossWith(Parent2.Value);
                    nextGeneration.Add(new KeyValuePair<int, Chromosome>(child.Fitness(),child));
                }
            }
            Chromosomes = nextGeneration;
        }

        public static bool NextStep()
        {
            MergeChromosomes();
            ChooseGoodChromosomes();
            return FindResult;
        }

        public static string ChromosomesToString()
        {
            string result = "";
            foreach(var ch in Chromosomes)
            {
                result += ch.Value.ToString() + "\r\n";
            }
            return result;
        }

    }
}
