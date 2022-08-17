using System.Collections.Generic;

namespace Capitulo9
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public IList<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; set; }
        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }
    }
}
