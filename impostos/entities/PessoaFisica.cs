using System;

namespace Impostos.entities
{
    internal class PessoaFisica : Pessoa
    { 
        public double GastSaude { get; set; }  

        public PessoaFisica() { }

        public PessoaFisica(string nome,double rendaAnual,double gastSaude): base(nome, rendaAnual)
        {
            GastSaude = gastSaude;
        }

        public override double ImpostaTotal()
        {
            double total = 0.0;

            if (RendaAnual <= 20.000)
            {
                double imposto = RendaAnual * 0.15;
                double gastos = GastSaude * 0.50;
                return  total += imposto - gastos;
            }
            else
            {
                double imposto = RendaAnual * 0.25;
                double gastos = GastSaude * 0.50;
                return total += imposto - gastos;
            }
            
        }
    }
}
