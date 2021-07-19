using Abstract_Factory_Pattern.Interfaces;

namespace Abstract_Factory_Pattern
{
    /// <summary>
    /// ProdutoB2
    /// </summary>
    class SamsungGuru : INormalPhone
    {
        public string BuscarDetahesModelo()
        {
            return "Modelo: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
