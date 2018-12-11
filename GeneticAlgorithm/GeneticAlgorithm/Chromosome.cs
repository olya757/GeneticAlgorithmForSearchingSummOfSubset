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
            return Math.Abs(Genetic.Value - Summ());
        }
        public Chromosome RandomCrossWith(Chromosome Parent)
        {
            Chromosome Child = new Chromosome(false);
            Child.Genes=Genes.Merge(Parent.Genes);
            return Child;
        }

        public int Count()
        {
            return Genes.Count();
        }

        public Chromosome Mutate()
        {
            Chromosome chromosome = new Chromosome(false);
            chromosome.Genes = Genes.Mutation();
            return chromosome;
        }

        public Chromosome(bool random)
        {
            Genes = new Genes(Genetic.Genes, random);
        }


        public KeyValuePair<int,Chromosome> GetKeyValuePair()
        {
            return new KeyValuePair<int, Chromosome>(Fitness(), this);
        }
        public override string ToString()
        {
            return Genes.ToString();
         
        }
    }
}
