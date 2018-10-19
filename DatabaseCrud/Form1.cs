using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCrud
{
    public partial class Form1 : Form
    {
        int contador=0; //Variable to be sent to messagebox
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            if(contador<=10)
                MessageBox.Show("Counter Value: " + contador.ToString());
        }
    }
}
