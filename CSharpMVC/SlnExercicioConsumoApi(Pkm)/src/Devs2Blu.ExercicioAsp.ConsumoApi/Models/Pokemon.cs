namespace Devs2Blu.ExercicioAsp.ConsumoApi.Models
{
    public class Pokemon
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<ResultsPokemon> results { get; set; }
    }

    public class ResultsPokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
