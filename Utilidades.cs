using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Estoque
{
    internal class Utilidades
    {
        //PUBLIC - para que todos os forms se comuniquem entre si (todos fora da tela -arquivo- não podem interagir sem essa váriavel)
        // PARÂMETRO - 

        public void mostraMensagem()
        {
            MessageBox.Show("Oi, sumido :)");
        }

        public bool textBoxEstaVazio ( TextBox txt  )     
        {
            if ( txt.Text == "" )
            {
                return true;                                //Se estiver vazio retorne uma true, pois está vazio
            }
            else
            {
                return false;                                // Se não, não está vazio
            }
        }

    }
}
