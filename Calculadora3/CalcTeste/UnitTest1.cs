using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora3;
namespace CalcTeste
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            Calculadora soma = new Calculadora();
            decimal somaDeValores = soma.Somar(soma.numero1 = 2, soma.numero2 = 5);
            Assert.AreEqual(7, somaDeValores);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculadora subtracao = new Calculadora();
            decimal subDeValores = subtracao.Subtrair(subtracao.numero1 = 10, subtracao.numero2 = 5);
            Assert.AreEqual(5, subDeValores);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculadora mult = new Calculadora();
            decimal multDeValores = mult.Multiplicar(mult.numero1 = 6, mult.numero2 = 6);
            Assert.AreEqual(36, multDeValores);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculadora div = new Calculadora();
            decimal divDeValores = div.Dividir(div.numero1 = 10, div.numero2 = 2);
            Assert.AreEqual(5, divDeValores);
        }
    }
}