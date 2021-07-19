using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creater
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
