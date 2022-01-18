using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3
{
    public partial class Form2 : Form
    {
        int jedna, dva, tri, sude,liche=0,soucetlich=0;
        double prumer;
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jedna = Convert.ToInt32(numericUpDown1.Value);
            dva = Convert.ToInt32(numericUpDown2.Value);
            tri = Convert.ToInt32(numericUpDown3.Value);
            if(jedna%2==0)
            {
                sude++;            
            }
            else
            {
                soucetlich = soucetlich + jedna;
                liche++;
            }
            if (dva % 2 == 0)
            {
                sude++;
            }
            else
            {
                soucetlich = soucetlich + dva;
                liche++;
            }
            if (dva % 2 == 0)
            {
                sude++;
            }
            else
            {
                soucetlich = soucetlich + tri;
                liche++;
            }
            
            
            if (soucetlich!=0)
            {
                prumer = soucetlich / liche;
                string prum = Convert.ToString(prumer);
                MessageBox.Show("Aritmetický průměr lichých čísel je: "+ prum, "aritmetický průměr");
            }
            if(sude!=0)
            {
                string sud = Convert.ToString(sude);
                MessageBox.Show("Součet sudých čísel je: "+ sud, "Počet sudých");
            }
        }
    }
}
