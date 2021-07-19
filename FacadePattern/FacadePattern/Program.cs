using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RestauranteFacade();
            Console.WriteLine("------------------------PEDIDOS DE PIZZA DO CLIENTE------------------------");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            Console.WriteLine("------------------------PEDIDOS DE PÃO DO CLIENTE------------------------");
            facade.BuscarPaoDeAlho();
            facade.BuscarPaoDeAlhoComQueijo();
        }
    }
}
