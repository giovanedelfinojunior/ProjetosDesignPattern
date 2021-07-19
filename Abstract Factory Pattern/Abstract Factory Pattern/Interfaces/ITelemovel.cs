using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern.Interfaces {
    /// <summary>
    /// AbstractProduto
    /// </summary>
    public interface ITelemovel {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();
    }
}
