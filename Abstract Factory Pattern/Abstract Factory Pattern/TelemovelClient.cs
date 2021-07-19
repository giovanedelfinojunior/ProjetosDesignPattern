using Abstract_Factory_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            smartPhone = telemovelFactory.BuscarSmartPhone();
            normalPhone = telemovelFactory.BuscarNormalPhone();
        }


        public string BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone.BuscarDetahesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetahesModelo();
        }
    }
}
