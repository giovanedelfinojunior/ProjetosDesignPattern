using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern
{
    /// <summary>
    /// ProdutoA2
    /// </summary>
    class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetahesModelo()
        {
            return "Modelo: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
