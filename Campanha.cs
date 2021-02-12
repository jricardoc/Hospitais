namespace ProjetoHospitais
{
    public class Campanha : Hospital
    {   
        public int QuantRespiradores { get; set; }

        public override float valorTotalPessoal()
        {
            return base.valorTotalPessoal() + (QuantRespiradores * 0.3f);
        }
    }
}