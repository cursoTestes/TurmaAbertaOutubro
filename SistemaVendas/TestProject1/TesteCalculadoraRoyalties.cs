using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SistemaVendas;

namespace TestProject1
{
    [TestClass]
    public class TesteCalculadoraRoyalties
    {
        

        [TestMethod]
        public void calculaRoyaltyDe1VendaDe100DeveRetornar20()
        {
            //arrange
            decimal valorDaVenda = 100;
            decimal royaltyEsperado = 20;
            int mes = 1;
            int ano = 1900;

            Mock<IVendaRepository> mockDeRepositorioVenda = new Mock<IVendaRepository>();
            Mock<ICalculadora> mockCalculadora = new Mock<ICalculadora>();

            mockCalculadora.Setup(calc => calc.CalculaComissao(valorDaVenda)).Returns(0);
            mockDeRepositorioVenda
                .Setup(venda => venda.selectVendasPorMes(mes, ano))
                .Returns(new List<decimal>() { valorDaVenda }); 

            //act
            CalculadoraRoyalties calculadoraRoyalties = new CalculadoraRoyalties(mockDeRepositorioVenda.Object, mockCalculadora.Object);
            decimal retorno = calculadoraRoyalties.calculaRoyalties(mes,ano);

            //assert
            Assert.AreEqual(royaltyEsperado, retorno);   
        }

        [TestMethod]
        public void calculaRoyaltyDe2VendasProMesEAnoDe50ReaisDeveRetornar20()
        {
            //arrange
            decimal valorDaVenda = 50;
            decimal royaltyEsperado = 20;
            int mes = 1;
            int ano = 1900;

            Mock<IVendaRepository> mockDeRepositorioVenda = new Mock<IVendaRepository>();
            Mock<ICalculadora> mockCalculadora = new Mock<ICalculadora>();

            mockCalculadora.Setup(calc => calc.CalculaComissao(valorDaVenda)).Returns(0);
            mockDeRepositorioVenda
                .Setup(venda => venda.selectVendasPorMes(mes, ano))
                .Returns(new List<decimal>() { valorDaVenda, valorDaVenda });

            //act
            CalculadoraRoyalties calculadoraRoyalties = new CalculadoraRoyalties(mockDeRepositorioVenda.Object, mockCalculadora.Object);
            decimal retorno = calculadoraRoyalties.calculaRoyalties(mes, ano);


            //assert
            Assert.AreEqual(royaltyEsperado, retorno);
        }

        [TestMethod]
        public void calculaRoyaltyDe1VendaDe1000ReaisDeveRetornar200()
        {
            //arrange
            decimal valorDaVenda = 1000;
            decimal royaltyEsperado = 200;
            int mes = 1;
            int ano = 1900;

            Mock<IVendaRepository> mockDeRepositorioVenda = new Mock<IVendaRepository>();
            Mock<ICalculadora> mockCalculadora = new Mock<ICalculadora>();

            mockCalculadora.Setup(calc => calc.CalculaComissao(valorDaVenda)).Returns(0);
            mockDeRepositorioVenda
                .Setup(venda => venda.selectVendasPorMes(mes, ano))
                .Returns(new List<decimal>() { valorDaVenda });

            //act
            CalculadoraRoyalties calculadoraRoyalties = new CalculadoraRoyalties(mockDeRepositorioVenda.Object, mockCalculadora.Object);
            decimal retorno = calculadoraRoyalties.calculaRoyalties(mes, ano);


            //assert
            Assert.AreEqual(royaltyEsperado, retorno);
            mockCalculadora.Verify(calc => calc.CalculaComissao(valorDaVenda), Times.AtLeastOnce());
        }
    }
}
