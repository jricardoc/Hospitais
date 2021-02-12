using System;

namespace ProjetoHospitais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programad de Hospitais");


            Hospital h1 = new Hospital();
            h1.SalMedioFuncionarios = 4000;
            h1.Nome = "ABC";
            h1.QuantFuncionarios = 30;
            Console.WriteLine("Valor total médio com pessoal: " + h1.valorTotalPessoal() + " no hospital " + h1.Nome);
            
            Upa upa = new Upa();
            upa.QuantAmbulancias = 5;
            upa.Nome = "UPA";
            upa.QuantFuncionarios = 30;
            upa.SalMedioFuncionarios = 4000;
            Console.WriteLine("Valor total médio com pessoal: " + upa.valorTotalPessoal() + " no hospital " + upa.Nome);

            Campanha c = new Campanha();
            c.QuantFuncionarios = 30;
            c.SalMedioFuncionarios = 4000;
            c.Nome = "Hospital de Campanha";
            c.QuantRespiradores = 10;
            Console.WriteLine("Valor total médio com pessoal: " + c.valorTotalPessoal() + " no hospital " + c.Nome);

        }
    }
}
