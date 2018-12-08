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
            btnNext.Enabled = false;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            List<string> Snums = tBGenes.Text.Split(' ').ToList<string>();
            List<int> nums = Snums.ConvertAll<int>((s)=>(int.Parse(s)));
            int Value = (int)nUDValue.Value;
            Data.Init(nums, Value, 100);
            tBChromosomes.Text = Data.ChromosomesToString();
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Data.NextStep();
            tBChromosomes.Text = Data.ChromosomesToString();
            if (Data.FindResult)
            {
                MessageBox.Show("Лучший результат найден!\r\n" + Data.Chromosomes.First().ToString());
            }
        }


    }
}
