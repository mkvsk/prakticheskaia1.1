using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakticheskaia1_byNeshik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name1 = "";
        string name2 = "";
        string name3 = "";

        int value1;
        int value2;
        int value3;

        int sum = 0;
        int max = 0;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxQuantity1.Text = "";
            textBoxQuantity2.Text = "";
            textBoxQuantity3.Text = "";

            textBoxSumResult.Text = "";
            textBoxMaxResult.Text = "";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxQuantity1.Text);
            value2 = int.Parse(textBoxQuantity2.Text);
            value3 = int.Parse(textBoxQuantity3.Text);

            sum = value1 + value2 + value3;
            textBoxSumResult.Text = "Всего " + sum + " грибов";
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            name1 = textBoxName1.Text;
            name2 = textBoxName2.Text;
            name3 = textBoxName3.Text;

            MaxValue(value1, value2, value3,
            name1, name2, name3);
        }

        void MaxValue(int value1, int value2, int value3, 
            string name1, string name2, string name3)
        {   
            int[] arr = { value1, value2, value3};
            max = arr.Max();

            var sb = new System.Text.StringBuilder();

            string str = "Больше всех грибов у ";
            string sk = " (";
            string sk2 = ")";

            if (max == value1)
            {
                textBoxMaxResult.Text = str + name1 + sk + value1.ToString() + sk2;
            }
            if (max == value2)
            {
                textBoxMaxResult.Text = str + name2 + sk + value2.ToString() + sk2;
            }
            if (max == value3)
            {
                textBoxMaxResult.Text = str + name3 + sk + value3.ToString() + sk2;
            }
        }
    }
}
