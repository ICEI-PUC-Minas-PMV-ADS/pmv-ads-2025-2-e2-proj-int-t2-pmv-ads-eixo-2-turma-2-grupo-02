namespace AgrInov.Models.ViewModels
{
    public class RelatorioMetasViewModel
    {
        public int Ano { get; set; }
        public List<ComparacaoMetaProducao> Comparacoes { get; set; } = new List<ComparacaoMetaProducao>();
    }

    public class ComparacaoMetaProducao
    {
        public string NomeCultura { get; set; }
        public int QuantidadeMeta { get; set; }
        public int ProducaoReal { get; set; }
        public int Diferenca => ProducaoReal - QuantidadeMeta;
        
        public decimal PercentualAlcancado
        {
            get
            {
                if (QuantidadeMeta > 0)
                {
                    return (decimal)ProducaoReal / QuantidadeMeta * 100;
                }
                else if (ProducaoReal > 0)
                {
                    return -1; // Indicador de "sem meta"
                }
                return 0;
            }
        }
        
        public bool MetaAlcancada => QuantidadeMeta > 0 && ProducaoReal >= QuantidadeMeta;
        
        public bool TemMeta => QuantidadeMeta > 0;
    }
}
