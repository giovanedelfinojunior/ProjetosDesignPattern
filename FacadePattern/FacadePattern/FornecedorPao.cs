using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo Pão de Alho.");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão de Alho com Queijo.");
        }
        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
