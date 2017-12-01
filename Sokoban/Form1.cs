using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class Form1 : Form
    {
        Bitmap B;
        Graphics G;

        public Form1()
        {
            InitializeComponent();
            B = new Bitmap(640, 640);
            G = Graphics.FromImage(B);
            G.Clear(Color.White);
            pictureBox1.Image = B;
        }
    }
}
