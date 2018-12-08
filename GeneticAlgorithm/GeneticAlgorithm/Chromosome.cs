using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Chromosome
    {
        public Genes Genes { get; set; }

        public int Summ()
        {
            return Genes.Summ();
        }

        public int Fitness()
        {            
            return Math.Abs(Data.Value - Summ());
        }
        public Chromosome RandomCrossWith(Chromosome Parent)
        {
            Chromosome Child = new Chromosome(false);
            Child.Genes=Genes.Merge(Parent.Genes);
            return Child;
        }


        public Chromosome(bool random)
        {
            Genes = new Genes(Data.Genes, random);
        }
        public override string ToString()
        {
            return Genes.ToString();
         
        }
    }
}
