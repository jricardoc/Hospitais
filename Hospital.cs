namespace ProjetoHospitais
{
    public class Hospital
    {
        
        public string Nome { get; set; }
        public int QuantFuncionarios { get; set; }
        public string Endereco { get; set; }
        public float SalMedioFuncionarios { get; set; }

        public virtual float valorTotalPessoal(){
            return QuantFuncionarios * SalMedioFuncionarios;
        }
    }
}