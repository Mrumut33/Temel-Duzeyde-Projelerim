using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private object t;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _ = t;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, yarıcap, dkalan, dkcevre, cemberalan, cembercevre;
            double pi;
            uzunkenar = Convert.ToInt32(TxtDkdrtgnUk.Text);
            kısakenar = Convert.ToInt32(TxtDkdrtgnKk.Text);
            yarıcap = Convert.ToInt32(TxtCmbrCap.Text);
            pi = 3.14;

            dkalan = kısakenar * uzunkenar;
            TxtDkdtgnA.Text = dkalan.ToString(); 
            dkcevre = 2 * (kısakenar + uzunkenar);
            TxtDkdrtgnC.Text = dkcevre.ToString();

            cemberalan = (int)(pi * yarıcap * yarıcap);
            TxtCmbrA.Text = cemberalan.ToString();
            cembercevre = (int)(2 * pi * yarıcap);
            TxtCmbrC.Text = cembercevre.ToString();








        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, yarıcap, dkalan, dkcevre;
            
           
            uzunkenar = Convert.ToInt32(TxtDkdrtgnUk.Text);
            kısakenar = Convert.ToInt32(TxtDkdrtgnKk.Text);
            
            dkalan = kısakenar * uzunkenar;
            TxtDkdtgnA.Text = dkalan.ToString();
            dkcevre = 2 * (kısakenar + uzunkenar);
            TxtDkdrtgnC.Text = dkcevre.ToString();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int yaricap, cemberalan, cembercevre, pi;
            pi = 3;
            yaricap = Convert.ToInt32(TxtCmbrCap.Text);
            cemberalan = (int)(pi * yaricap * yaricap);
            TxtCmbrA.Text = cemberalan.ToString();
            cembercevre = (int)(2 * pi * yaricap);
            TxtCmbrC.Text = cembercevre.ToString();
        }

        private void TxtCmbrA_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

