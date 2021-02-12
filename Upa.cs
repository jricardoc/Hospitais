namespace ProjetoHospitais
{
    public class Upa : Hospital
    {
        public int QuantAmbulancias { get; set; }

        public override float valorTotalPessoal(){
            return (QuantFuncionarios + QuantAmbulancias) * SalMedioFuncionarios;
        }
    }
}