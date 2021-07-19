using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    class NokiaPixel : ISmartPhone
    {
        public string BuscarDetahesModelo()
        {
            return "Modelo: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
