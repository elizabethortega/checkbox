using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChechBoxcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
           




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float numero1, numero2, suma, resta;

            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            suma = numero1 + numero2;
            resta = numero2 - numero1;
            if (rdbOpcion1.Checked == true)
            {
                txtResultado.Text = suma.ToString();
            }
            if (rdbOpcion2.Checked == true)
            {
                txtResultado.Text = resta.ToString();
            }





        }
    }
}
