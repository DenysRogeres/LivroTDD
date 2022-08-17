using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if(funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                return DezOuVintePorCentoDeDesconto(funcionario);
            }

            else if(funcionario.Cargo.Equals(Cargo.DBA) || funcionario.Cargo.Equals(Cargo.TESTADOR))
            {
                return QuinzeOuVinteCincoPorCentoDeDesconto(funcionario);
            }
            throw new Exception("Funcionario invalido");
        }

        public double QuinzeOuVinteCincoPorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario > 2500)
            {
                return funcionario.Salario * 0.75;
            }
            return funcionario.Salario * 0.85;
        }

        public double DezOuVintePorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }
    }
}

