using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

//Concrete
namespace DecoratorPattern {
    public class BaconDecorator : PizzaDecorator{

      public BaconDecorator(IPizza pizza)
        : base(pizza) {
      }

        public override string BuscarTipoPizza() {
            {
                var pizza = base.BuscarTipoPizza();
                pizza += "\r\n com extra de bacon";
                return pizza;
            }
        }
    }
}
