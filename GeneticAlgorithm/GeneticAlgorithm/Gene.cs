using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Genes
    {
        public List<KeyValuePair<int,bool>> ListOfGenes { get; set; }

        public int Count()
        {
            int res = 0;
            foreach(var g in ListOfGenes)
            {
                if (g.Value)
                    res++;
            }
            return res;
        }

        public bool HaveGene(int index)
        {
            return ListOfGenes[index].Value;
        }

        public void SetGen(int index)
        {
            if (!ListOfGenes[index].Value)
            {
                ListOfGenes[index] = new KeyValuePair<int, bool>(ListOfGenes[index].Key, true);
            }
            
        }
        public int Summ()
        {
            int res = 0;
            foreach (var i in ListOfGenes)
            {
                if (i.Value)
                    res += i.Key;
            }
            return res;
        }

        public Genes(List<int> g,bool random)
        {
            ListOfGenes = new List<KeyValuePair<int, bool>>();
            foreach(var tmpG in g)
            {
                ListOfGenes.Add(new KeyValuePair<int, bool>(tmpG, random && Genetic.Random.Next(0, 2) == 0));
            }
        }

        public Genes Merge(Genes Parent)
        {
            Genes genesTmp = new Genes(Genetic.Genes,false);
            for (int i=0;i<ListOfGenes.Count();i++)
            {
                if (ListOfGenes[i].Value && Genetic.Random.Next(0, 2) == 0)
                    genesTmp.SetGen(i);
            }
            for (int i=0; i < Parent.ListOfGenes.Count(); i++)
            {
                if (Parent.ListOfGenes[i].Value && Genetic.Random.Next(0, 2) == 0)
                    genesTmp.SetGen(i);
            }
            return genesTmp;
        }

        public override string ToString()
        {
            string res = "";
            foreach (var g in ListOfGenes)
            {
                if (g.Value)
                    res += g.Key.ToString() + ' ';
            }
            res += "Sum: " + Summ().ToString();
            return res;
        }

        public Genes Mutation()
        {
            Genes genes = new Genes(Genetic.Genes, false);
            for (int i=0;i<Genetic.Genes.Count();i++)
            {
                if (ListOfGenes[i].Value||Genetic.Random.Next(0, 2) == 0)
                 genes.SetGen(i);
            }
            return genes;
        }
    }
}
