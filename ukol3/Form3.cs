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
    public partial class Form3 : Form
    {
        int jedna, dva, tri, ctyri,soucet,soucin;
        double prumer;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            jedna = Convert.ToInt32(textBox1.Text);
            dva = Convert.ToInt32(textBox2.Text);
            tri = Convert.ToInt32(textBox3.Text);
            ctyri = Convert.ToInt32(textBox4.Text);
                if(radioButton1.Checked==true || radioButton2.Checked==true || radioButton3.Checked==true)
                {
                    if(radioButton1.Checked == true)
                    {
                        soucet = jedna + dva + tri + ctyri;

                        label1.Text = "Součet je: " + soucet;
                    }
                    if(radioButton2.Checked == true)
                    {
                        soucin = jedna * dva * tri * ctyri;
                        label1.Text = "Součin je: " + soucin;
                    }
                    if (radioButton3.Checked == true)
                    {
                        prumer = (jedna + dva + tri + ctyri) / 4;

                        label1.Text = "Průměr je: " + prumer;
                    }
                }
                else
                {

                    MessageBox.Show("CHYBA, není zaškrtlý radiobutton!");

                }
            }catch
            {

                MessageBox.Show("CHYBA!");
            }

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
