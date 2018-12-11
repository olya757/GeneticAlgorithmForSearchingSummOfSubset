using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            List<string> Snums = tBGenes.Text.Split(' ').ToList<string>();
            List<int> nums = Snums.ConvertAll<int>((s)=>(int.Parse(s)));
            int Value = (int)nUDValue.Value;
            int AmountOfGenerations = (int)nUDAmountOfGenerations.Value;
            int AmountOfFirst = (int)nUDAmountOfFirstGeneration.Value;
            int ProbOfMutation = (int)nUDProb.Value;
            int Top = (int)nUDTop.Value;
            Genetic.NewGeneration(nums, Value, AmountOfFirst, ProbOfMutation, AmountOfGenerations, Top);
            tBChromosomes.Text = Genetic.ChromosomesToString();
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tBChromosomes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
