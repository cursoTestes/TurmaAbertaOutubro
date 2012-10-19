using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaVendas;

namespace TestProject1
{
    [TestClass]
    public class TesteCalculadora
    {
        [TestMethod]
        public void Teste_CalculaComissao_Venda100_Retorna5()
        {
            decimal total_venda = 100;
            decimal valor_esperado = 5;
            Calculadora calculadora = new Calculadora();
            decimal comissao = calculadora.CalculaComissao(total_venda);

            Assert.AreEqual(valor_esperado, comissao);            
        }
         [TestMethod]
        public void Teste_CalculaComissao_Venda10000_Retorna500()
        {
            decimal total_venda = 10000;
            decimal valor_esperado = 500;

            Calculadora calculadora = new Calculadora();
            decimal comissao = calculadora.CalculaComissao(total_venda);

            Assert.AreEqual(valor_esperado, comissao);
        }

         [TestMethod]
         public void Teste_CalculaComissao_Venda0_Retorna0()
         {
             decimal total_venda = 0;
             decimal valor_esperado = 0;

             Calculadora calculadora = new Calculadora();
             decimal comissao = calculadora.CalculaComissao(total_venda);

             Assert.AreEqual(valor_esperado, comissao);
         }

         [TestMethod]
         public void Teste_CalculaComissao_Venda11000_Retorna660()
         {
             decimal total_venda = 11000;
             decimal valor_esperado = 660;

             Calculadora calculadora = new Calculadora();
             decimal comissao = calculadora.CalculaComissao(total_venda);

             Assert.AreEqual(valor_esperado, comissao);
         }

         [TestMethod]
         public void Teste_CalculaComissao_Venda10001_Retorna600Reais_6centavos()
         {
             decimal total_venda = 10001;
             decimal valor_esperado = 600.06m;

             Calculadora calculadora = new Calculadora();
             decimal comissao = calculadora.CalculaComissao(total_venda);

             Assert.AreEqual(valor_esperado, comissao);
         }


         [TestMethod]
         public void Teste_CalculaComissao_Venda10_Retorna50Centavos()
         {
             decimal total_venda = 10;
             decimal valor_esperado = 0.50m;

             Calculadora calculadora = new Calculadora();
             decimal comissao = calculadora.CalculaComissao(total_venda);

             Assert.AreEqual(valor_esperado, comissao);
         }
    
        
         [TestMethod]
         public void Teste_CalculaComissao_Venda9999reais_99centavos_Retorna499Reais_99centavos()
         {
             decimal total_venda = 9999.99m;
             decimal valor_esperado = 499.99m;

             Calculadora calculadora = new Calculadora();
             decimal comissao = calculadora.CalculaComissao(total_venda);

             Assert.AreEqual(valor_esperado, comissao);
         }

    }

}

