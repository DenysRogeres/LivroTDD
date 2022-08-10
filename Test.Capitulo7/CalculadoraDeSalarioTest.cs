using Capitulo7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Capitulo7
{
    [TestClass]
    public class CalculadoraDeSalarioTest
    {
        [TestMethod]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500 * 0.9, salario);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.85, salario);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4500 * 0.75, salario);

        }
    }
}
