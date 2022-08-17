using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9
{
    public class ProcessadorDeBoletos
    {
        Boleto boleto = boletos[0];

        Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);

        fatura.Pagamentos.Add(pagamento);

        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach(var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);
            }
        }
    }
}
