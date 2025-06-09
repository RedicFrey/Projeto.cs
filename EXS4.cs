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
    public partial class EXS4 : Form
    {
        public EXS4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 0;


            if (checkedListBox1.GetItemChecked(0))
            {
                valor += 1;
            }
                


            if (checkedListBox1.GetItemChecked(1))
            {
                valor += 2;
            }
                


            if (checkedListBox1.GetItemChecked(2))
            {
                valor += 3;
            }
                
        
            
            if (checkedListBox1.GetItemChecked(3))
            {
                valor += 4;
            }

            if (checkedListBox2.GetItemChecked(0))
            {
                valor += 5;
            }



            if (checkedListBox2.GetItemChecked(1))
            {
                valor += 6;
            }



            if (checkedListBox2.GetItemChecked(2))
            {
                valor += 7;
            }



            if (checkedListBox2.GetItemChecked(3))
            {
                valor += 8;
            }

            txt.Text = "Valor total: " + valor.ToString();

        }
    }
}
