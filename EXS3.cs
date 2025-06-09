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
    public partial class EXS3 : Form
    {
        public EXS3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                this.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked)
            {
                
                this.BackColor = Color.Yellow;
            }
            else if (radioButton3.Checked)
            {
                
                this.BackColor = Color.Red;
            }
            else if (radioButton4.Checked)
            {
                // coloquei esse aqui de extra 
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
