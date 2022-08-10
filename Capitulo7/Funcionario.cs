using System;

namespace Capitulo7
{
    public class Funcionario
    {
        public String Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }

        public Funcionario(String nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
}
