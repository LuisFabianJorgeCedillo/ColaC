using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola
{
    public partial class FormDeCola : Form
    {

         DeCola dc = new DeCola();

        public FormDeCola()
        {
            InitializeComponent();
        }


        private void InsertarDelante_Click(object sender, EventArgs e)
        {
            string z = txtnumero3.Text;
            if (dc.Llena())
            {
                MessageBox.Show("La Cola esta llena ");
            }
            else
            {
                dc.Insertar(z);
                 listBox3.Items.Add(z);
            }
            txtnumero3.Clear();

        }

        private void InsertarDetras_Click(object sender, EventArgs e)
        {


        }

        private void EliminarDelante_Clcik(object sender, EventArgs e)
        {

        }

        private void EliminarDetras_Click(object sender, EventArgs e)
        {

        }

       
    }
}
