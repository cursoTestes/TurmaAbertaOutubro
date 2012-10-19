using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{

    public interface ICalculadora
    {
        decimal CalculaComissao(decimal totalVendas);
    }

    public class Calculadora : ICalculadora
    {
        public decimal CalculaComissao(decimal totalVendas)
        {
            decimal valorComissao;
            if (totalVendas <= 10000)
            {
                valorComissao = totalVendas * 5 / 100;
            }

            else
            {
                valorComissao = totalVendas * 6 / 100;
            }

            return Math.Floor(valorComissao * 100)/100;
             

            
        }
    }
}
