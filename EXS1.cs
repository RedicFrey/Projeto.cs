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
    public partial class EXS1 : Form
    {
        public EXS1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inicio = int.Parse(cmbinicio.Text);
            int fim = int.Parse(cmbfim.Text);
            int cont = inicio;

            if(inicio > fim)
            {
                listnumeros.Text = "";
                while(true) {

                    listnumeros.Items.Add(cont);
                    cont--;
                    

                    if (cont < fim) { break; }

                }
                
            }
            if (fim > inicio)
            {
                listnumeros.Text = "";
                while (true)
                {

                    listnumeros.Items.Add(cont);
                    cont++;


                    if (cont > fim) { break; }

                }

            }    
                
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbfim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inicio = int.Parse(cmbinicio.Text);
            int fim = int.Parse(cmbfim.Text);
            int cont = inicio;

            if (inicio > fim)
            {
                listnumeros.Text = "";
                while (true)
                {

                    listnumeros.Items.Add(cont);
                    cont--;


                    if (cont < fim) { break; }

                }

            }
            if (fim > inicio)
            {
                listnumeros.Text = "";
                while (true)
                {

                    listnumeros.Items.Add(cont);
                    cont++;


                    if (cont > fim) { break; }

                }

            }


        }
    }
}
