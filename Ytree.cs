using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ytree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;   
     
      

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)

        {    if (n == 0) return;
          
            n = Convert.ToInt32(textBox1.Text);
            leng = Convert.ToInt32(textBox2.Text);
            double th1= Convert.ToInt32(textBox3.Text);
            double th2= Convert.ToInt32(textBox4.Text);
            double per1 = Convert.ToInt32(textBox5.Text);
            double per2=Convert.ToInt32(textBox6.Text);
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);

            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            if  (check1.checked)
            Pens.Blue; 
            if(check2.checked) 
               Pens.Red;
          graphics.DrawLine(
   
            (int)x0, (int)y0, (int)x1, (int)y1);

        }


                }
        }
    }
}






