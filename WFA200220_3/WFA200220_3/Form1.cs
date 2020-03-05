using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200220_3
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        Color eSzin;
        public Form1()
        {
            InitializeComponent();
            eSzin = this.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gomb.Text = gomb.Text.ToUpper();
        }

        private void gomb_MouseEnter(object sender, EventArgs e)
        {
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void gomb_MouseMove(object sender, MouseEventArgs e)
        {
            cimke.Text = $"X: {Cursor.Position.X}, Y: {Cursor.Position.Y}";
        }

        private void gomb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = eSzin;
            gomb.Text = gomb.Text.ToLower();
        }
    }
}
