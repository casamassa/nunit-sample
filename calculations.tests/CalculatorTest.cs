using NUnit.Framework;

namespace calculations.tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Soma_DeveRetornarOValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Soma(10, 20);
            //Verifica se o resultado é igual a 30
            Assert.AreEqual(30, resultado);
        }

        [Test]
        public void RestoDivisao_DeveRetornarOValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.RestoDivisao(10, 3);
            //Verifica se o quociente da divisão é 3 e o resto 1
            Assert.Multiple(() =>
            {
                Assert.That(3, Is.EqualTo(resultado.quociente));
                Assert.That(1, Is.EqualTo(resultado.resto));
            });
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            Calculator c = new Calculator();
            var resultado = c.RestoDivisao(12, value);
            //Verifica se o resto da divisão é 0
            Assert.That(0, Is.EqualTo(resultado.resto));
        }

        [Test]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Subtracao(20, 10);
            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }

        [Test]
        public void Divisao_DeveRetornarOValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Divisao(100, 10);
            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }

        [Test]
        public void Multiplicacao_DeveRetornarOValorCorreto()
        {
            Calculator c = new Calculator();
            var resultado = c.Multiplicacao(5, 2);
            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }
    }
}