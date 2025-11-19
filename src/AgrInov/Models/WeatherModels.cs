using System.Collections.Generic;

namespace AgrInov.Models
{
    public class PrevisaoDiaria
    {
        public string date { get; set; }
        public string weekday { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public string description { get; set; }
    }

    public class PrevisaoResultado
    {
        public List<PrevisaoDiaria> forecast { get; set; } = new List<PrevisaoDiaria>();
        public string city_name { get; set; }
    }

    public class PrevisaoRaiz
    {
        public PrevisaoResultado results { get; set; }
    }
}