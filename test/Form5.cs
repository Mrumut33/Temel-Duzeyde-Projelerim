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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir= Convert.ToInt32(TxtMisir.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(TxtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = Convert.ToString(kasatutar) + " TL";

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
