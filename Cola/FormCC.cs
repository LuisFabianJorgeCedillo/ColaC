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
    public partial class FormCC : Form
    {
          
          ColaC cc = new ColaC();

        public FormCC()
        {
            InitializeComponent();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            string y = txtnumero2.Text;
            if (cc.Vacia1()) MessageBox.Show("Error: Cola esta VACIA");
            else
            {
                cc.Insertar1(y);
                listBox1.Items.Insert(0,y);
            }
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            string y;
            if (cc.Llena1())
                MessageBox.Show("Error; la cola de elemento esta vacio");
            else
            {
                y = cc.Eliminar1();
                listBox1.Items.Remove(y);
            }
        }

    }
}
