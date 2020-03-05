using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200220_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float akts = lblSzoveg.Font.Size;
            akts += 3;

            lblSzoveg.Font = new Font(
                lblSzoveg.Font.FontFamily,
                akts);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float akts = lblSzoveg.Font.Size;
            if((akts - 3) > 0)akts -= 3;

            lblSzoveg.Font = new Font(
                lblSzoveg.Font.FontFamily,
                akts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSzoveg.ForeColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblSzoveg.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
