using Abstract_Factory_Pattern.Interfaces;
using System;

namespace Abstract_Factory_Pattern.ConcretesFactory
{
    /// <summary>
    /// ConcreteFactory1
    /// </summary>
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
