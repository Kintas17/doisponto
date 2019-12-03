using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        triangulo T = new triangulo();

        private void Button1_Click(object sender, EventArgs e)
        {
            T.P1.X = Convert.ToDouble(x1.Text);
            T.P1.Y = Convert.ToDouble(y1.Text);
            T.P2.X = Convert.ToDouble(x2.Text);
            T.P2.Y = Convert.ToDouble(y2.Text);
            T.P3.X = Convert.ToDouble(x3.Text);
            T.P3.Y = Convert.ToDouble(y3.Text);
            T.P1.Z = Convert.ToDouble(z1.Text);
            T.P2.Z = Convert.ToDouble(z2.Text);
            T.P3.Z = Convert.ToDouble(z3.Text);


            if (area.Checked) label4.Text = T.Area.ToString();
            else if (perimetro.Checked) label4.Text = T.Perimetro.ToString();
        }
    }
}
