using System;


namespace Impostos.entities
{
    internal class PessoaJuritica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuritica() { }

        public PessoaJuritica(string nome,double rendaAnual,int funcionarios):base (nome,rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double ImpostaTotal()
        {
            double total = 0.0;
            if(Funcionarios > 10) 
            {
                return total += RendaAnual * 0.14;
            }
            else
            {
                return total += RendaAnual * 0.16;
            }
        }
    }
}
