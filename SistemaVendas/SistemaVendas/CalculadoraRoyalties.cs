using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public class CalculadoraRoyalties
    {

        private IVendaRepository repository;
        private ICalculadora calculadora;

        public CalculadoraRoyalties(IVendaRepository repository, ICalculadora calculadora)
        {
            this.repository = repository;
            this.calculadora = calculadora;
        }

        public decimal calculaRoyalties(int mes, int ano)
        {
            List<decimal> vendasPorMes = repository.selectVendasPorMes(mes, ano);
            decimal total = 0;

            foreach (decimal valor in vendasPorMes)
            {
                decimal valorLiquido = valor - calculadora.CalculaComissao(valor);
                total = total + valorLiquido;
            }

            return total * 0.2m;
        }
    }
}
