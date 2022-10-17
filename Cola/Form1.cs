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
    
    public partial class Form1 : Form
    {
        public Cola1 c = new Cola1();
        public Form1()
        {  
            InitializeComponent();
        }

     


        //Otro formulario
        private void button3_Click(object sender, EventArgs e)
        {
            Form colaC = new FormCC();
            colaC.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form DeCola = new FormDeCola();
            DeCola.Show();
        }


        
        private void insertar_Click(object sender, EventArgs e)
        {
            string x = txtnumero.Text;
            if (c.Llena())
            {
                MessageBox.Show("La  cola esta llena");
            }
            else
            {
                c.Insertar(x);
                listBox1.Items.Add(x);
            }
            txtnumero.Clear();
            txtnumero.Focus();
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {
            string x;
            if (c.Vacia())
                MessageBox.Show("Error: la cola de elemento esta vacio");
            else
            {
                x = c.Eliminar();
                listBox1.Items.Remove(x);
            }

        }      
    }
}
