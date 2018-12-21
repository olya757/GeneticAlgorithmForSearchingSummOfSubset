using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public static class Genetic
    {
        public static Thread thread { get; set; }
        public static List<int> Genes { get; set; }
        public static int Value { get; set; }
        public static int StartAmount { get; set; }
        public static int ProbabilityOfMutation { get; set; }
        public static int AmountOfGenerations { get; set; }
        public static int TopAmount { get; set; }

        public static DateTime StartTime { get; set; }
        public static TimeSpan TimeOfAlgorithm { get; set; }

        public static List<KeyValuePair<int,Chromosome>> Chromosomes { get; private set; }

        public static event ChangeTextBoxAndLabel Change;
        //public static bool FindResult { get; set; }
        public static void NewGeneration(List<int> genes,int value, int startAmount, int VerOfMut,int aofGen,int Top)
        {
            
            Genes = genes;
            Value = value;
            StartAmount = startAmount;
            ProbabilityOfMutation = VerOfMut;
            AmountOfGenerations = aofGen;
            TopAmount = Top;
            Chromosomes = new List<KeyValuePair<int, Chromosome>>();
            
            Genes.Sort();
            CreateFirstGeneration();
            thread = new Thread(FindResult);
            thread.Start();

        }

        
        public static Random Random = new Random();
        public static void CreateFirstGeneration()
        {
            for(int i = 0; i < StartAmount; i++)
            {
                Chromosome chromosome = new Chromosome(true);
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
                if (p1.Value.Count() > p2.Value.Count()) return 1;
                if (p1.Value.Count() < p2.Value.Count()) return -1;
                return 0;
            });
            int finish = (int)(TopAmount * Chromosomes.Count()/100);
            List<KeyValuePair<int, Chromosome>> tmp = new List<KeyValuePair<int, Chromosome>>();
            foreach(var ch in Chromosomes)
            {
                tmp.Add(ch);
                finish--;
                if (finish < 0) break;
            }
            Chromosomes = tmp;
        }
        
        public static void MergeAndMutateChromosomes()
        {
            List<KeyValuePair<int, Chromosome>> nextGeneration = new List<KeyValuePair<int, Chromosome>>();
            for (int i=0;i<Chromosomes.Count();)
            {
                var Parent1 = Chromosomes[i];
                i++;
                MutateChromosome(Parent1.Value, ref nextGeneration);
                nextGeneration.Add(Parent1);
                if (i<Chromosomes.Count())
                {
                    var Parent2 = Chromosomes[i];
                    i++;
                    MutateChromosome(Parent1.Value, ref nextGeneration);
                    nextGeneration.Add(Parent2);
                    Chromosome child = Parent1.Value.RandomCrossWith(Parent2.Value);
                    nextGeneration.Add(new KeyValuePair<int, Chromosome>(child.Fitness(),child));
                }
            }
            Chromosomes = nextGeneration;
        }

        public static void MutateChromosome(Chromosome chromosome, ref List<KeyValuePair<int,Chromosome>> chroms)
        {
            if (Random.Next(0, 100) < ProbabilityOfMutation)
            {
                Chromosome mut1 = chromosome.Mutate();
                chroms.Add(mut1.GetKeyValuePair());
            }
        }


        public static void NextStep()
        {
            MergeAndMutateChromosomes();
            ChooseGoodChromosomes();
        }

        public static void FindResult()
        {
            DateTime st = System.DateTime.Now;
            for (int i = 1; i < AmountOfGenerations; i++)
                NextStep();
            TimeOfAlgorithm = System.DateTime.Now - st;
            Change(ChromosomesToString(), TimeOfAlgorithm.Ticks.ToString());
            Form1.Ready++;
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
