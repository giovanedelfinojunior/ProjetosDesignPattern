using Abstract_Factory_Pattern.Interfaces;
using System;

namespace Abstract_Factory_Pattern.ConcretesFactory
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
