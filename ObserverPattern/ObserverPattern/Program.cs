using System;

namespace ObserverPattern {
    class Program {
        static void Main(string[] args) {
            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();

            NovasAgenciasNoticias agenciaNoticias1 = new NovasAgenciasNoticias("Agencia de Noticia de Joinville");
            estacaoMeteorologica.Anexar(agenciaNoticias1);

            NovasAgenciasNoticias agenciaNoticias2 = new NovasAgenciasNoticias("Agencia de Noticia de São Francisco");
            estacaoMeteorologica.Anexar(agenciaNoticias2);

            estacaoMeteorologica.Temperatura = 31.4f;
            estacaoMeteorologica.Temperatura = 25f;
            estacaoMeteorologica.Temperatura = 26.7f;
            estacaoMeteorologica.Temperatura = 34.7f;
            estacaoMeteorologica.Temperatura = 22.7f;
            estacaoMeteorologica.Temperatura = 15.7f;

            Console.ReadLine();
        }
    }
}
