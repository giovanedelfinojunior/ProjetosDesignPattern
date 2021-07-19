using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    class Nokia1600 : INormalPhone
    {
        public string BuscarDetahesModelo()
        {
            return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
