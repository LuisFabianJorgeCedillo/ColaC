using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola
{
    internal class DeCola : Cola1
    {
        public DeCola()
        {
            primero = 0;
            ultimo = -1;
        }
        


        public void InsertarAdelante(string insert)
        {
            ultimo++;
            for (int i = ultimo - 1; i < MaxCola; i--)
            {
                coladatos[i + 1] = coladatos[i];
                coladatos[ultimo] = insert;
            }
        }
           


        public void InsertarAtras(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La colaD de elementos esta LLENA");
            else
            {
                primero++;
                for (int i = primero-1; i<=ultimo; i++)
                {
                    coladatos[i + 1] = coladatos[i];
                    coladatos[primero] = insert;
                }
            }
        }
             



    }
}
