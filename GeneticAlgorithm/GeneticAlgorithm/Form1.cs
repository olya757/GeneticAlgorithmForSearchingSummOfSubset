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
            Ready = 2;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (Ready < 2) return;
            Ready = 0;
            List<string> Snums = tBGenes.Text.Trim(' ').Split(' ').ToList<string>();
            List<int> nums = Snums.ConvertAll<int>((s)=>(int.Parse(s)));
            int Value = (int)nUDValue.Value;
            int AmountOfGenerations = (int)nUDAmountOfGenerations.Value;
            int AmountOfFirst = (int)nUDAmountOfFirstGeneration.Value;
            int ProbOfMutation = (int)nUDProb.Value;
            int Top = (int)nUDTop.Value;
            Genetic.Change += ChangeGen;
            Algorithm.Change += ChangeRight;
            Genetic.NewGeneration(nums, Value, AmountOfFirst, ProbOfMutation, AmountOfGenerations, Top);
            Algorithm.Result(nums, Value);
        }

        public static int Ready { get; set; }

        public void ChangeGen(string tb, string lb)
        {
            Action action = () =>
            {
                tBChromosomes.Text = tb;
                lbGen.Text = lb;
            };
            Invoke(action);
        }

        public void ChangeRight(string tb, string lb)
        {
            Action action = () =>
            {
                tBSearchResult.Text = tb;
                lbRight.Text = lb;
            };
            Invoke(action);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tBChromosomes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
