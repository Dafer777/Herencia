using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear instacncia de la clase Rectangle

          
            box box = new box();

            box.length = 10;
            box.widht = 5;
            box.height = 15;
            

            MessageBox.Show(box.getLength());
            MessageBox.Show(box.Area());
            MessageBox.Show(box.heigh());
            MessageBox.Show(box.volumen());
        }
    }
}
