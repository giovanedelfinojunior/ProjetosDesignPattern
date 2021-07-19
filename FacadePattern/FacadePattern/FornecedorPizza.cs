using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
   public class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando Pizza Normal.");
        }
        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando Pizza Vegana.");
        }
        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vegetais.");
        }
    }
}
