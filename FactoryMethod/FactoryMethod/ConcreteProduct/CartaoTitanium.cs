using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcreteProduct
{
    class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrançaAnual;

        public CartaoTitanium(int limiteCredito, int cobrançaAnual)
        {
            this._tipoCartao = "Titanium";
            this._limiteCredito = limiteCredito;
            this._cobrançaAnual = cobrançaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }


        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public override int CobrancaAnual
        {
            get { return _cobrançaAnual; }
            set { _limiteCredito = value; }
        }
    }
}
