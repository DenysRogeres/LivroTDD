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
                if (funcionario.Salario > 3000)
                {
                    return funcionario.Salario*0.8;
                }
                return funcionario.Salario * 0.9;
            }

            else if(funcionario.Cargo.Equals(Cargo.DBA))
            {
                if(funcionario.Salario > 2500)
                {
                    return funcionario.Salario * 0.75;
                }
                return funcionario.Salario * 0.85;
            }
            throw new Exception("Funcionario invalido");
        }
    }
}

