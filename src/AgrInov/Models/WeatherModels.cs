using System.Collections.Generic;

namespace AgrInov.Models
{
    // Modelo para cada dia da previsão
    public class PrevisaoDiaria
    {
        public string date { get; set; }
        public string weekday { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public string description { get; set; }
    }
    
    // Modelo para o objeto "results" que contém a lista
    public class PrevisaoResultado
    {
        public List<PrevisaoDiaria> forecast { get; set; } = new List<PrevisaoDiaria>();
        public string city_name { get; set; }
    }

    // Modelo "Raiz" para a resposta completa da API
    public class PrevisaoRaiz
    {
        public PrevisaoResultado results { get; set; }
    }
}