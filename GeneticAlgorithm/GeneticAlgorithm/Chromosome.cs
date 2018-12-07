using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Chromosome
    {
        public List<int> Genes { get; set; }

        public int Summ()
        {
            int res = 0;
            foreach (var i in Genes)
            {
                res += i;
            }
            return res;
        }

        public int Fitness()
        {            
            return Math.Abs(Data.Value - Summ());
        }
        public Chromosome RandomCrossWith(Chromosome Parent)
        {
            Chromosome Child = new Chromosome();
            Random rnd = new Random();
            foreach(var g in Genes)
            {
                if (rnd.Next(0, 2) == 0)
                    Child.Genes.Add(g);
            }
            foreach (var g in Parent.Genes)
            {
                if (rnd.Next(0, 2) == 0)
                    Child.Genes.Add(g);
            }
            return Child;
        }

        public Chromosome SmartCrossWith(Chromosome Parent)
        {
            Chromosome Child = new Chromosome();
            //здесь будет что то умное
            return Child;
        }

        public Chromosome()
        {
            Genes = new List<int>();
        }

        public Chromosome(List<int> genes)
        {
            Genes = new List<int>();
            Random rnd = new Random();
            foreach (var g in genes)
            {
                if (rnd.Next(0, 2) == 0)
                    Genes.Add(g);
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach(var g in Genes)
            {
                res += g.ToString() + ' ';
            }
            res += "Sum: " + Summ().ToString();
            return res;
        }
    }
}
