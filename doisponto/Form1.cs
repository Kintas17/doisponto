using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doisponto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void X2_Load(object sender, EventArgs e)
        {


        }
        distância p1 = new distância();
        distância p2 = new distância();

        private void Button1_Click(object sender, EventArgs e)
        {
            p1.X = Convert.ToDouble(x1.Text);
            p1.Y= Convert.ToDouble(y1.Text);
            p2.X = Convert.ToDouble(textBox3.Text);
            p2.Y = Convert.ToDouble(y2.Text);

            label1.Text = (Math.Sqrt(Math.Pow(p2.X - p1.X,2)+Math.Pow(p2.Y - p1.Y, 2))).ToString();
        }
    }
}
