using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.cs
{
    public partial class EXS2 : Form
    {
        public EXS2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string text;

            text = textBox1.Text;

            text.ToUpper();

            label2.Text = text.ToUpper(); 
        }
    }
}
