using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200220_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var c in this.Controls)
                if (c is PictureBox) (c as PictureBox).Click += PictureBoxClick;
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                this.BackColor = (sender as PictureBox).BackColor;
            }
        }
    }
}
