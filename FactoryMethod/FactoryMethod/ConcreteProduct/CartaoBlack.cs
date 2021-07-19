using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcreteProduct
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrançaAnual;

        public CartaoBlack(int limiteCredito, int cobrançaAnual)
        {
            this._tipoCartao = "Black";
            this._limiteCredito = limiteCredito;
            this._cobrançaAnual = cobrançaAnual;
        }

        public override string TipoCartao { 
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
